using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Handlers.Orders.Queries
{
    public class GetOrderDetailsDtoQuery : IRequest<IDataResult<IEnumerable<OrderDetailsDto>>>
    {
        public class GetOrderDetailsDtoQueryHandler : IRequestHandler<GetOrderDetailsDtoQuery, IDataResult<IEnumerable<OrderDetailsDto>>>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IMediator _mediator;

            public GetOrderDetailsDtoQueryHandler(IOrderRepository orderRepository , IMediator mediator)
            {
                _orderRepository = orderRepository;
                _mediator = mediator;
            }

            [PerformanceAspect(5)]
            [CacheAspect(10)]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<IEnumerable<OrderDetailsDto>>> Handle(GetOrderDetailsDtoQuery request, CancellationToken cancellationToken)
            {
                return new SuccessDataResult<IEnumerable<OrderDetailsDto>>(await _orderRepository.GetOrderDetailsDto());
            }
        }
    }
}
