
using Business.BusinessAspects;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Aspects.Autofac.Logging;
namespace Business.Handlers.WareHouses.Queries
{

	public class GetWareHouseByProductIdAndSizeQuery : IRequest<IDataResult<WareHouse>>
	{
		public int ProductId { get; set; }
		public string Size { get; set; }

		public class GetWareHouseByProductIdAndSizeQueryHandler : IRequestHandler<GetWareHouseByProductIdAndSizeQuery, IDataResult<WareHouse>>
		{
			private readonly IWareHouseRepository _wareHouseRepository;
			private readonly IMediator _mediator;

			public GetWareHouseByProductIdAndSizeQueryHandler(IWareHouseRepository wareHouseRepository, IMediator mediator)
			{
				_wareHouseRepository = wareHouseRepository;
				_mediator = mediator;
			}
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IDataResult<WareHouse>> Handle(GetWareHouseByProductIdAndSizeQuery request, CancellationToken cancellationToken)
			{

                var wareHouseByProductIdAndSize = await _wareHouseRepository.GetAsync(p => p.ProductId == request.ProductId && p.Size == request.Size && p.Status == true && p.isDeleted==false);
                return new SuccessDataResult<WareHouse>(wareHouseByProductIdAndSize);
			}
		}
	}
}
