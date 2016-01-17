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
            switch (products.Count())
            {
                case 1:
                    Price = products.Sum(p => p.Price);
                    break;
                case 2:
                    Price = products.Sum(p => p.Price) * (decimal)(1 - 0.05);
                    break;
                case 3:
                    Price = products.Sum(p => p.Price) * (decimal)(1 - 0.10);
                    break;
                case 4:
                    Price = products.Sum(p => p.Price) * (decimal)(1 - 0.20);
                    break;
            }

            return Price;
        }
    }
}
