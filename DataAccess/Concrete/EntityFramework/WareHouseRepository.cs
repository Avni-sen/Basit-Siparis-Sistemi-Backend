
using System;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Abstract;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class WareHouseRepository : EfEntityRepositoryBase<WareHouse, ProjectDbContext>, IWareHouseRepository
	{
		public WareHouseRepository(ProjectDbContext context) : base(context)
		{
		}

		public async Task<List<WareHouseDto>> GetWareHouseDetailsDto()
		{

			var result = await (from warehouse in Context.WareHouses
								join product in Context.Products
								on warehouse.ProductId equals product.Id
								where warehouse.isDeleted == false
								select new WareHouseDto
								{
									Id = warehouse.Id,
									ProductId = product.Id,
									ProductName = product.ProductName,
									Status = warehouse.Status,
									isDeleted = warehouse.isDeleted,
									Amount = warehouse.Amount,
									CreatedDate = warehouse.CreatedDate,
									CreatedUserId = warehouse.CreatedUserId,
									IsReadyForSell = warehouse.IsReadyForSell,
									LastUpdatedDate = warehouse.LastUpdatedDate,
									LastUpdatedUserId = warehouse.LastUpdatedUserId
								}).ToListAsync();
                return result;
           
        }
	}
}
