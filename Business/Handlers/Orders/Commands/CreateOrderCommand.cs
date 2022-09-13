
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
        public int Amount { get; set; }


        public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, IResult>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IWareHouseRepository _wareHouseRepository;
            private readonly IMediator _mediator;
            public CreateOrderCommandHandler(IOrderRepository orderRepository, IMediator mediator, IWareHouseRepository wareHouseRepository)
            {
                _orderRepository = orderRepository;
                _mediator = mediator;
                _wareHouseRepository = wareHouseRepository;
            }

            [ValidationAspect(typeof(CreateOrderValidator), Priority = 1)]
            [CacheRemoveAspect("Get")]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IResult> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                var isThereOrderRecord = _orderRepository.Query()
                    .Any(u => u.ProductId == request.ProductId && u.CustomerId == request.CustomerId && u.Amount == request.Amount && u.isDeleted == false);

                //var isOkeyWareHouse = _wareHouseRepository.Query().Any(u => u.ProductId == request.ProductId && u.Amount >= request.Amount && u.IsReadyForSell==true && u.isDeleted ==false);
                //var Amount = _wareHouseRepository.Get(u=>u.ProductId == request.ProductId).Amount;
                if (isThereOrderRecord == true /*&& isOkeyWareHouse!=true*/)
                    return new ErrorResult(Messages.NameAlreadyExist);
             
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
                    Amount = request.Amount,

                };


                //var updateWareHouse = new WareHouse
                //{
                //Amount = Amount - request.Amount
                //};

                //_wareHouseRepository.Update(updateWareHouse);
                //await _wareHouseRepository.SaveChangesAsync();

                _orderRepository.Add(addedOrder);
                await _orderRepository.SaveChangesAsync();
                return new SuccessResult(Messages.Added);
            }
        }
    }
}