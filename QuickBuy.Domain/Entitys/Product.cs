﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
        public decimal Value { get; set; }

    }
}
