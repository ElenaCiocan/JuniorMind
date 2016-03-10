using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shoppings
{
    [TestClass]
    public class Shoppings
    {
        [TestMethod]
        public void TestForFindingTheTotal()
        {
            var products = new Product[] { new Product("Cake", 50), new Product("Coke", (decimal)10.50), new Product("Chips", 25), new Product("Chocolate", (decimal)15.25) };
            Assert.AreEqual((decimal)100.75, CalculateTotal(products));
        }

        [TestMethod]
        public void TestForFindingTheCheapestProduct()
        {
            var products = new Product[] { new Product("Cake", 50), new Product("Coke", (decimal)15.50), new Product("Chips", 25), new Product("Chocolate", (decimal)8.25) };
            Assert.AreEqual("Chocolate", FindOutTheCheapestProduct(products));

        }

        [TestMethod]
        public void TestForMeanValue()
        {
            var products = new Product[] { new Product("Cake", 50), new Product("Coke", (decimal)15.50), new Product("Chips", 25), new Product("Chocolate", (decimal)8.25) };
            Assert.AreEqual((decimal)24.6875, CalculateMeanValue(products));
        }

        struct Product
        {
            public string name;
            public decimal price;
            public Product(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }
        }

        decimal CalculateTotal( Product[] products)
        {
            decimal total=0;
            for (int i = 0; i < products.Length; i++)
                total += products[i].price;
            return total;
        }

        string FindOutTheCheapestProduct( Product[] products)
        {
            decimal theCheapestProduct = products[0].price;
            int noProduct = 0;
            for (int i = 1; i < products.Length; i++)
                if (products[i].price < theCheapestProduct)
                {
                    theCheapestProduct = products[i].price;
                    noProduct = i;
                }
            return products[noProduct].name;
        }

        decimal CalculateMeanValue( Product[] products)
        {
            decimal sum = CalculateTotal(products);
            return sum /products.Length;
        }
    }
}
