
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
using Business.Handlers.WareHouses.ValidationRules;

namespace Business.Handlers.WareHouses.Commands
{
	/// <summary>
	/// 
	/// </summary>
	public class CreateWareHouseCommand : IRequest<IResult>
	{

		public int CreatedUserId { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public int LastUpdatedUserId { get; set; }
		public System.DateTime LastUpdatedDate { get; set; }
		public bool Status { get; set; }
		public bool isDeleted { get; set; }
		public int ProductId { get; set; }
		public int Amount { get; set; }
		public string Size { get; set; }
		public bool IsReadyForSell { get; set; }


		public class CreateWareHouseCommandHandler : IRequestHandler<CreateWareHouseCommand, IResult>
		{
			private readonly IWareHouseRepository _wareHouseRepository;
			private readonly IMediator _mediator;
			public CreateWareHouseCommandHandler(IWareHouseRepository wareHouseRepository, IMediator mediator)
			{
				_wareHouseRepository = wareHouseRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(CreateWareHouseValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(CreateWareHouseCommand request, CancellationToken cancellationToken)
			{
				var isThereWareHouseRecord = _wareHouseRepository.Query().Any(u=>u.ProductId == request.ProductId &&  u.Amount == request.Amount && u.IsReadyForSell == true && u.isDeleted ==false);

				if (isThereWareHouseRecord == true)
					return new ErrorResult(Messages.NameAlreadyExist);

				var addedWareHouse = new WareHouse
				{
					CreatedUserId = request.CreatedUserId,
					CreatedDate = request.CreatedDate,
					LastUpdatedUserId = request.LastUpdatedUserId,
					LastUpdatedDate = request.LastUpdatedDate,
					Status = request.Status,
					Size = request.Size,
					isDeleted = request.isDeleted,
					ProductId = request.ProductId,
					Amount = request.Amount,
					IsReadyForSell = request.IsReadyForSell,

				};

				_wareHouseRepository.Add(addedWareHouse);
				await _wareHouseRepository.SaveChangesAsync();

				return new SuccessResult(Messages.Added);
			}
		}
	}
}