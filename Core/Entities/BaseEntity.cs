﻿using System;

namespace Core.Entities
{
    public class BaseEntity : IEntity
    {
        public virtual int Id { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int LastUpdatedUserId { get; set; }
        public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
        public bool Status { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
