﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day2_homework
{
    public class ShoppingCart
    {
        public static decimal CheckOut(List<Product> products)
        {
            return products.Sum(p => p.Price);
        }
    }
}