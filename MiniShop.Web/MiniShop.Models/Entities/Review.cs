﻿using MayNghien.Infrastructure.Models.Entity;
using MiniShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models.Entities
{
    public class Review : BaseEntity
    {
        public string ProductName { get; set; }
        public Ratings Rating { get; set; }
        public string? Comment { get; set; }

        //[ForeignKey("Tenant")]
        //public Guid? TenantId { get; set; }
        //public Tenant? Tenant { get; set; }

        [ForeignKey("Product")]
        public Guid? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
