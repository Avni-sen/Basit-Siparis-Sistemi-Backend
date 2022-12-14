
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
using Business.Handlers.Products.ValidationRules;
using System;
using Entities.Enums;
using static Entities.Enums.ESizeTypeEnum;

namespace Business.Handlers.Products.Commands
{


	public class UpdateProductCommand : IRequest<IResult>
	{
		public int Id { get; set; }
		public int CreatedUserId { get; set; }
		public int LastUpdatedUserId { get; set; }
		public bool Status { get; set; }
		public bool isDeleted { get; set; }
		public string ProductName { get; set; }
		public string ProductColor { get; set; }
		public string Size { get; set; }

		public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, IResult>
		{
			private readonly IProductRepository _productRepository;
			private readonly IMediator _mediator;

			public UpdateProductCommandHandler(IProductRepository productRepository, IMediator mediator)
			{
				_productRepository = productRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(UpdateProductValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
			{
				var isThereProductRecord = await _productRepository.GetAsync(u => u.Id == request.Id);
                var isThereCustomerProperty = _productRepository.Query()
                   .Any(u => u.ProductName == request.ProductName && u.ProductColor == request.ProductColor && u.Size == request.Size && u.isDeleted == false);

				if (isThereCustomerProperty != true)
				{
                    isThereProductRecord.CreatedUserId = request.CreatedUserId;
                    isThereProductRecord.CreatedDate = DateTime.Now;
                    isThereProductRecord.LastUpdatedUserId = request.LastUpdatedUserId;
                    isThereProductRecord.LastUpdatedDate = DateTime.Now;
                    isThereProductRecord.Status = request.Status;
                    isThereProductRecord.isDeleted = request.isDeleted;
                    isThereProductRecord.ProductName = request.ProductName;
                    isThereProductRecord.ProductColor = request.ProductColor;
                    isThereProductRecord.Size = request.Size;


                    _productRepository.Update(isThereProductRecord);
                    await _productRepository.SaveChangesAsync();
                    return new SuccessResult(Messages.Updated);
                }

               return new ErrorResult(Messages.NameAlreadyExist);
			}
		}
	}
}

