using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample
{
    public class Program
    {
        static void Main()
        {

            //local constant
            const string developerName = "Merv";
            Console.WriteLine(developerName);

            //initialize fields
            Product product1 = new Product { Name = "Mobile", Id = 1001, Price = 3000.5, };
            Product.NumberOfProducts++;
            Product product2 = new Product { Name = "Laptop", Id = 1002, Price = 2000 };
            Product.NumberOfProducts++;
            Product product3 = new Product { Name = "Tablet", Id = 1003, Price = 5000.5 };
            Product.NumberOfProducts++;
            //instance fields : allocated separately for each object

            //get values from fields
            Console.WriteLine("ID: " + product1.Id);
            Console.WriteLine(product2.Name);
            Console.WriteLine(product3.Price);
            Console.WriteLine("Total no.of products: " + Product.NumberOfProducts);
            Console.WriteLine("Category of products: " + Product.CategoryName);
            Console.WriteLine("Category ID of products: " + product1.CategoryId);

            Console.ReadKey();

        }
    }
}
