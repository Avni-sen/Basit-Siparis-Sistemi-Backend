using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using static Entities.Enums.ESizeTypeEnum;

namespace Entities.Concrete
{
    public class Product : BaseEntity,IEntity
    {
        public string ProductName { get; set; }
        public string ProductColor { get; set; }

        public string Size { get; set; }
    }
}
