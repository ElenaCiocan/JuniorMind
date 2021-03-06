﻿using System;
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
            Assert.AreEqual(products[3], FindOutTheCheapestProduct(products));

        }

        [TestMethod]
        public void TestForMeanValue()
        {
            var products = new Product[] { new Product("Cake", 50), new Product("Coke", (decimal)15.50), new Product("Chips", 25), new Product("Chocolate", (decimal)8.25) };
            Assert.AreEqual((decimal)24.6875, CalculateMeanValue(products));
        }

        [TestMethod]
        public void TestForDeletingTheMostExpensiveProduct()
        {
            var products = new Product[] { new Product("Cake",(decimal)10.25), new Product("Coke", (decimal)15.50), new Product("Chips", 25), new Product("Chocolate", (decimal)8.25) };
            deleteTheMostExpensiveProduct(products);
            Assert.IsTrue(products[products.Length - 2].name != "Chips");
        }
        
        [TestMethod]
        public void TestForAddingANewElement()
        {
            var products = new Product[] { new Product("Cake", (decimal)10.25), new Product("Coke", (decimal)15.50), new Product("Chips", 25), new Product("Chocolate", (decimal)8.25) };
            AddANewProduct(ref products);
            Assert.IsTrue(products[products.Length-1].name != "Chocolate");
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

        Product FindOutTheCheapestProduct( Product[] products)
        {
            decimal theCheapestProduct = products[0].price;
            int noProduct = 0;
            for (int i = 1; i < products.Length; i++)
                if (products[i].price < theCheapestProduct)  
                    noProduct = i;
            return products[noProduct];
        }

        void deleteTheMostExpensiveProduct(Product[] products)
        {
            int noProduct = FindIndexOfTheMostExpensiveProduct(products);
            products[noProduct] = products[products.Length - 1];
            Array.Resize(ref products, products.Length - 1);
        }

        private static int FindIndexOfTheMostExpensiveProduct(Product[] products)
        {
            decimal theCheapestProduct = products[0].price;
            int noProduct = 0;
            for (int i = 1; i < products.Length; i++)
                if (products[i].price > theCheapestProduct)
                    noProduct = i;
            return noProduct;
        }

        void AddANewProduct(ref Product[] products)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1].price = (decimal)25.08;
            products[products.Length - 1].name = "Candy";
        }

        decimal CalculateMeanValue( Product[] products)
        {
            decimal sum = CalculateTotal(products);
            return sum /products.Length;
        }
    }
}
