using Business.BusinessAspects;
using Business.Handlers.Orders.Queries;
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
using System.Threading.Tasks;
using System.Threading;

namespace Business.Handlers.WareHouses.Queries
{
    public class GetWareHouseDetailsDtoQuery : IRequest<IDataResult<IEnumerable<WareHouseDto>>>
    {
        public class GetWareHouseDetailsDtoQueryHandler : IRequestHandler<GetWareHouseDetailsDtoQuery, IDataResult<IEnumerable<WareHouseDto>>>
        { 
            private readonly IWareHouseRepository _wareHouseRepository;
            private readonly IMediator _mediator;

            public GetWareHouseDetailsDtoQueryHandler(IWareHouseRepository wareHouseRepository, IMediator mediator)
            {
                _wareHouseRepository = wareHouseRepository;
                _mediator = mediator;
            }

            [PerformanceAspect(5)]
            [CacheAspect(10)]
            [LogAspect(typeof(FileLogger))]
            [SecuredOperation(Priority = 1)]
            public async Task<IDataResult<IEnumerable<WareHouseDto>>> Handle(GetWareHouseDetailsDtoQuery request, CancellationToken cancellationToken)
            {
                return new SuccessDataResult<IEnumerable<WareHouseDto>>(await _wareHouseRepository.GetWareHouseDetailsDto());
            }
        }
    }
    }

