using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GettAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            /*foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }*/
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/"+product.CategoryName);
            }
        }
    }
}
