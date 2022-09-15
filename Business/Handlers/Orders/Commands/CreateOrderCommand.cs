
using Business.BusinessAspects;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Business.Handlers.Orders.ValidationRules;
using System;
using Business.Handlers.WareHouses.Commands;
using Business.Handlers.WareHouses.Queries;

namespace Business.Handlers.Orders.Commands
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateOrderCommand : IRequest<IResult>
    {

        public int Id { get; set; }
        public int CreatedUserId { get; set; }
        public int LastUpdatedUserId { get; set; }
        public bool Status { get; set; }
        public bool isDeleted { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; }
        public int Amount { get; set; }


        public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, IResult>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IMediator _mediator;
            public CreateOrderCommandHandler(IOrderRepository orderRepository, IMediator mediator)
            {
                _orderRepository = orderRepository;
                _mediator = mediator;
            }

            [ValidationAspect(typeof(CreateOrderValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                //var isThereOrderRecord = _orderRepository.Query()
                //    .Any(u => u.ProductId == request.ProductId && u.CustomerId == request.CustomerId && u.Amount == request.Amount && u.Size ==request.Size && u.isDeleted == false);
                //var Amount = _wareHouseRepository.Get(u=>u.ProductId == request.ProductId).Amount;

                var isThereWareHouseRecord = await _mediator.Send(new ExistsProductQuery { Amount = request.Amount, ProductId = request.ProductId, Size = request.Size });
               

                if (isThereWareHouseRecord.Data != true /*&& isOkeyWareHouse!=true*/)
                    return new ErrorResult(Messages.NameAlreadyExist);

                var wareHouseRecord = await _mediator.Send(new GetWareHouseByProductIdAndSizeQuery { ProductId = request.ProductId, Size = request.Size });

                wareHouseRecord.Data.Amount = wareHouseRecord.Data.Amount - request.Amount;

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
                    var addedOrder = new Order
                    {
                        CreatedUserId = request.CreatedUserId,
                        CreatedDate = DateTime.Now,
                        LastUpdatedUserId = request.LastUpdatedUserId,
                        LastUpdatedDate = DateTime.Now,
                        Status = request.Status,
                        isDeleted = request.isDeleted,
                        CustomerId = request.CustomerId,
                        ProductId = request.ProductId,
                        Size = request.Size,
                        Amount = request.Amount,

                    };
                    _orderRepository.Add(addedOrder);
                    await _orderRepository.SaveChangesAsync();
                    return new SuccessResult(Messages.Added);
                }
                return new ErrorResult(updatedWareHouse.Message);

                //var updateWareHouse = new WareHouse
                //{
                //Amount = Amount - request.Amount
                //};

                //_wareHouseRepository.Update(updateWareHouse);
                //await _wareHouseRepository.SaveChangesAsync();

                
            }
        }
    }
}