﻿using System;

namespace OOP11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Alternatief 2 product eklemek için.
            Product product2 = new Product {Id=2, CategoryId=5, 
                UnitsInStock=5, ProductName="Kalem", UnitPrice= 35};

            // bellekte sol sag(Stake Heap). New = referans almasi için gerekli new.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            //int double bool deger tip
            // diziler class abstract class interface referans tip
            //ref out



        }
    }
}
