
using System;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Abstract;
using Core.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class OrderRepository : EfEntityRepositoryBase<Order, ProjectDbContext>, IOrderRepository
	{
		public OrderRepository(ProjectDbContext context) : base(context)
		{
		}

		//public async Task<Order> CreateOrderTheWareHouse()
		//{
		//	var result = await (from order in Context.Orders
		//						join wareHouse in Context.WareHouses
		//						on order.ProductId equals wareHouse.ProductId
		//						where order.Amount <= wareHouse.Amount
		//						where wareHouse.IsReadyForSell == true
		//						select new Order
		//						{
		//							Amount = order.Amount,
		//							ProductId = order.ProductId,
		//							CreatedDate = order.CreatedDate,
		//							CreatedUserId = order.CreatedUserId,
		//							CustomerId = order.CustomerId,
		//						}).ToListAsync();
		//	return result;
		//}

		public async Task<List<OrderDetailsDto>> GetOrderDetailsDto()
		{
			var result = await (from order in Context.Orders
								join customer in Context.Customers
								on order.CustomerId equals customer.Id
								join product in Context.Products
								on order.ProductId equals product.Id
								select new OrderDetailsDto()
								{
									ProductId = order.ProductId,
									CustomerId = order.CustomerId,
									Amount = order.Amount,
									CreatedDate = order.CreatedDate,
									CreatedUserId = order.CreatedUserId,
									CustomerName = customer.CustomerName,
									ProductName = product.ProductName,
									Status = order.Status,
									Id = order.Id,
									isDeleted = order.isDeleted,
									LastUpdatedDate = order.LastUpdatedDate,
									LastUpdatedUserId = order.LastUpdatedUserId,
								}).ToListAsync();
			return result;
		}


	}
}
