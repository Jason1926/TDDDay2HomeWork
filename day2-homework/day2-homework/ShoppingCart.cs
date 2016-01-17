using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day2_homework
{
    public class ShoppingCart
    {
        public static decimal CheckOut(List<Product> products)
        {
            decimal Price = 0;
            if (products.Count == 1)
            { Price = products.Sum(p => p.Price); }
            else if (products.Count == 2)
            { Price = products.Sum(p => p.Price) * (decimal)(1 - 0.05); }
            else if (products.Count == 3)
            { Price = products.Sum(p => p.Price) * (decimal)(1 - 0.10); }
            else if (products.Count == 4)
            { Price = products.Sum(p => p.Price) * (decimal)(1 - 0.20); }
            else if (products.Count == 5)
            { Price = products.Sum(p => p.Price) * (decimal)(1 - 0.25); }
         
            return Price;
        }
    }
}
