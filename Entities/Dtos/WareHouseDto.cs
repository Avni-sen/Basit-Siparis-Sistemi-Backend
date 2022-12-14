using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class WareHouseDto : BaseEntityDto, IDto
    {
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public string  Size { get; set; }
        public bool IsReadyForSell { get; set; }
    }
}
