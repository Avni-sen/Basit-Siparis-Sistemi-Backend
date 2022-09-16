
using Business.Constants;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Core.Aspects.Autofac.Validation;
using Business.Handlers.Orders.ValidationRules;
using System;
using Business.Handlers.WareHouses.Commands;
using Business.Handlers.WareHouses.Queries;

namespace Business.Handlers.Orders.Commands
{


	public class UpdateOrderCommand : IRequest<IResult>
	{
		public int Id { get; set; }
		public int CreatedUserId { get; set; }
		public int LastUpdatedUserId { get; set; }
		public bool Status { get; set; }
		public bool isDeleted { get; set; }
		public int CustomerId { get; set; }
		public int ProductId { get; set; }
		public int Amount { get; set; }
		public string Size { get; set; }

		public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, IResult>
		{
			private readonly IOrderRepository _orderRepository;
			private readonly IMediator _mediator;

			public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMediator mediator)
			{
				_orderRepository = orderRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(UpdateOrderValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
			{
                var isThereOrderRecord = await _orderRepository.GetAsync(u => u.Id == request.Id);
				var isThereWareHouseRecord = await _mediator.Send(new ExistsProductQuery { Amount = request.Amount, ProductId = request.ProductId, Size = request.Size });

				if (isThereWareHouseRecord.Data != true /*&& isOkeyWareHouse!=true*/)
					return new ErrorResult(Messages.NameAlreadyExist);

				var wareHouseRecord = await _mediator.Send(new GetWareHouseByProductIdAndSizeQuery { ProductId = request.ProductId, Size = request.Size });

				//güncelleme işleminde eğer ürün sayısı değiştirilirse değiştirilen ürün adedine göre depodaki ürün adet bilgisinin de güncellenmesi gerekir.
				var prevProductAmount = isThereOrderRecord.Amount;
				wareHouseRecord.Data.Amount = wareHouseRecord.Data.Amount - (request.Amount - prevProductAmount);

				var updatedWareHouse = await _mediator.Send(new UpdateWareHouseCommand
				{
					Amount = wareHouseRecord.Data.Amount,
					CreatedDate = wareHouseRecord.Data.CreatedDate,
					CreatedUserId = wareHouseRecord.Data.CreatedUserId,
					Id = wareHouseRecord.Data.Id,
					isDeleted = wareHouseRecord.Data.isDeleted,
					Status = wareHouseRecord.Data.Amount != 0,
					IsReadyForSell = wareHouseRecord.Data.IsReadyForSell,
					LastUpdatedDate = wareHouseRecord.Data.LastUpdatedDate,
					LastUpdatedUserId = wareHouseRecord.Data.LastUpdatedUserId,
					ProductId = wareHouseRecord.Data.ProductId,
					Size = wareHouseRecord.Data.Size,
				});

				if (updatedWareHouse.Success)
				{

					isThereOrderRecord.CreatedUserId = request.CreatedUserId;
					isThereOrderRecord.CreatedDate = DateTime.Now;
					isThereOrderRecord.LastUpdatedUserId = request.LastUpdatedUserId;
					isThereOrderRecord.LastUpdatedDate = DateTime.Now;
					isThereOrderRecord.Status = request.Status;
					isThereOrderRecord.isDeleted = request.isDeleted;
					isThereOrderRecord.CustomerId = request.CustomerId;
					isThereOrderRecord.ProductId = request.ProductId;
					isThereOrderRecord.Amount = request.Amount;
					isThereOrderRecord.Size = request.Size;


					_orderRepository.Update(isThereOrderRecord);
					await _orderRepository.SaveChangesAsync();
					return new SuccessResult(Messages.Updated);
				}
                return new ErrorResult(updatedWareHouse.Message);
            }
		}
	}
}

