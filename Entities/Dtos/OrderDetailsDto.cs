using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class OrderDetailsDto : BaseEntityDto,IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CustomerId { get; set; }
        public string  CustomerName { get; set; }
        public int Amount { get; set; }
    }
}
