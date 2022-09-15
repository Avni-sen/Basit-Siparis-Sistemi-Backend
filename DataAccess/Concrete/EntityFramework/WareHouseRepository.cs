
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

		public async Task<bool> ExistsProduct(int productId, string size, int amount)
		{
         var isOkeyWareHouse = await Context.WareHouses.AnyAsync(u => u.ProductId == productId && u.Amount >= amount && u.Size == size && u.IsReadyForSell == true && u.isDeleted == false);
			return isOkeyWareHouse;
        }

        public async Task<List<WareHouseDto>> GetWareHouseDetailsDto()
		{

			var result = await (from warehouse in Context.WareHouses
								join product in Context.Products on warehouse.ProductId equals product.Id into p from product in p.DefaultIfEmpty()

                                where warehouse.isDeleted == false
								select new WareHouseDto
								{
									Id = warehouse.Id,
									ProductId = product.Id,
									Size = warehouse.Size,
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
