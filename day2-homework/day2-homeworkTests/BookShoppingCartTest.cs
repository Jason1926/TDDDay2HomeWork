using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using day2_homework;
using System.Collections.Generic;

namespace day2_homeworkTests
{
    [TestClass]
    public class BookShoppingCartTest
    {
        [TestMethod]
        public void Test_BookShoppingCart_is_1Episode_1_Buy_by_TotalPrice_Should_Be_100()
        {
            var target = new ShoppingCart();

            var products = new  List<Product>(){new Product()};

            int actual = ShoppingCart.CheckOut(products);

            int expected =100;

            Assert.AreEqual(expected, actual);
        }
    }
}
