using System;
using System.Linq;
using DataAccess;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddOrderDetail();
            //AddProduct();

            using (var context = new FactoryPostgreContext())
            {
                context.Categories.Add(new Category {CategoryName = "Teknoloji"});
                context.SaveChanges();
            }
        }

        private static void AddProduct()
        {
            using (FactoryContext context = new FactoryContext())
            {
                Category category = context.Categories.First();
                OrderDetail order = context.OrderDetails.First();
                Product product = new Product
                {
                    ProductName = "Oyuncak araba", CategoryId = category.Id, OrderDetailId = order.Id, UnitsInStock = 15
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        private static void AddOrderDetail()
        {
            using (var context = new FactoryContext())
            {
                context.OrderDetails.Add(new OrderDetail
                {
                    Adress = "Trabzon", Price = 50
                });
                context.SaveChanges();
            }
        }
    }
}