using System.Collections.Generic;
using System.Linq;

namespace day2_homework
{
    public class ShoppingCart
    {
        public static decimal CheckOut(List<Product> products)
        {
            decimal Price = 0;

            //重新將書本群組化
            List<List<Product>> GroupProducts = ProductByGroup(products);

            //群組化計算價格
            Price = GroupProductTotalPrice(GroupProducts);

            return Price;
        }

        private static List<List<Product>> ProductByGroup(List<Product> Products)
        {
            List<List<Product>> StubGroupProducts = new List<List<Product>>();

            foreach (var Product in Products)
            {
                bool IsExist = false;
                for (int i = 0; i < StubGroupProducts.Count; i++)
                {
                    var StubProducts = StubGroupProducts[i];

                    var StubProduct = StubProducts.FirstOrDefault(p => p.Episode == Product.Episode);

                    if (StubProduct == null)
                    {
                        StubProducts.Add(Product);
                        IsExist = true;
                        break;
                    }
                    else { IsExist = false; }
                }

                if (IsExist == false)
                {
                    StubGroupProducts.Add(new List<Product>() { Product });
                }
            }

            return StubGroupProducts;
        }

        private static decimal GroupProductTotalPrice(List<List<Product>> GroupProducts)
        {
            decimal TotalPrice = 0;

            foreach (var Group in GroupProducts)
            {
                if (Group.Count == 1)
                { TotalPrice += Group.Sum(p => p.Price); }
                else if (Group.Count == 2)
                { TotalPrice += Group.Sum(p => p.Price) * (decimal)(1 - 0.05); }
                else if (Group.Count == 3)
                { TotalPrice += Group.Sum(p => p.Price) * (decimal)(1 - 0.10); }
                else if (Group.Count == 4)
                { TotalPrice += Group.Sum(p => p.Price) * (decimal)(1 - 0.20); }
                else if (Group.Count == 5)
                { TotalPrice += Group.Sum(p => p.Price) * (decimal)(1 - 0.25); }
            }

            return TotalPrice;
        }
    }
}