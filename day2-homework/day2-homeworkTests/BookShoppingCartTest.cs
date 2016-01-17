using day2_homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            var products = new List<Product>() { new Product() { Episode = "1", Price = 100 } };

            var actual = ShoppingCart.CheckOut(products);

            int expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_BookShoppingCart_is_1Episode_1_AND_2Episode_1_Buy_by_TotalPrice_Should_Be_190()
        {
            var target = new ShoppingCart();

            var products = new List<Product>() { 
                                                 new Product() { Episode = "1" , Price = 100 } ,
                                                 new Product() { Episode = "2" , Price = 100 }
                                               };

            var actual = ShoppingCart.CheckOut(products);

            int expected = 190;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_BookShoppingCart_is_1Episode_1_AND_2Episode_1_And_3Episode_1_Buy_by_TotalPrice_Should_Be_270()
        {
            var target = new ShoppingCart();

            var products = new List<Product>() { 
                                                 new Product() { Episode = "1" , Price = 100 } ,
                                                 new Product() { Episode = "2" , Price = 100 } ,
                                                 new Product() { Episode = "3" , Price = 100 } ,
                                               };

            var actual = ShoppingCart.CheckOut(products);

            int expected = 270;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_BookShoppingCart_is_1Episode_1_AND_2Episode_1_And_3Episode_1_AND_4Episode_1_Buy_by_TotalPrice_Should_Be_320()
        {
            var target = new ShoppingCart();

            var products = new List<Product>() { 
                                                 new Product() { Episode = "1" , Price = 100 } ,
                                                 new Product() { Episode = "2" , Price = 100 } ,
                                                 new Product() { Episode = "3" , Price = 100 } ,
                                                 new Product() { Episode = "4" , Price = 100 }
                                               };

            var actual = ShoppingCart.CheckOut(products);

            int expected = 320;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_BookShoppingCart_is_1Episode_1_AND_2Episode_1_And_3Episode_1_AND_4Episode_1_AND_5Episode_1_Buy_by_TotalPrice_Should_Be_375()
        {
            var target = new ShoppingCart();

            var products = new List<Product>() { 
                                                 new Product() { Episode = "1" , Price = 100 } ,
                                                 new Product() { Episode = "2" , Price = 100 } ,
                                                 new Product() { Episode = "3" , Price = 100 } ,
                                                 new Product() { Episode = "4" , Price = 100 } ,
                                                 new Product() { Episode = "5" , Price = 100 }
                                               };

            var actual = ShoppingCart.CheckOut(products);

            int expected = 375;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_BookShoppingCart_is_1Episode_1_AND_2Episode_1_And_3Episode_2_Buy_by_TotalPrice_Should_Be_370()
        {
            var target = new ShoppingCart();

            var products = new List<Product>() { 
                                                 new Product() { Episode = "1" , Price = 100 } ,
                                                 new Product() { Episode = "2" , Price = 100 } ,
                                                 new Product() { Episode = "3" , Price = 100 } ,
                                                 new Product() { Episode = "3" , Price = 100 } 
                                               };

            var actual = ShoppingCart.CheckOut(products);

            int expected = 370;

            Assert.AreEqual(expected, actual);
        }
   } 
}