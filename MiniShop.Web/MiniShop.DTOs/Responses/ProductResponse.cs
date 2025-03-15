﻿using MayNghien.Infrastructure.Models;
using MiniShop.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.DTOs.Responses
{
    public class ProductResponse : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Address Address { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
