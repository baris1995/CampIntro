﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Categoryİd = 2;
            product1.ProductName = "MASA";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2, Categoryİd=5, 
            UnitsInStock=5, ProductName=" Kalem",UnitPrice=35};


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

                





        }
    }
}