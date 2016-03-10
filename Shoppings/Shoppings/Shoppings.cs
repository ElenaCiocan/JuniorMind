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
    }
}
