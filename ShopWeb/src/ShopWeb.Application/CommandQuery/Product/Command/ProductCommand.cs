﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Application.CommandQuery.Product.Command
{
    public class ProductCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
