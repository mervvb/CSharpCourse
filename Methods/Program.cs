using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main()
        {
            //local constant 
            const string developerName = "Merv";

            //create reference variables

            Product product1, product2, product3;

            //create objects

            //directly
            /*
            product1 = new Product();
            Product.TotalNoProducts++; //1
            product2 = new Product();
            Product.TotalNoProducts++; //2
            product3 = new Product();
            Product.TotalNoProducts++; //3 */

            //indirectly
            product1 = new Product();
            Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //1
            product2 = new Product();
            Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //2
            product3 = new Product();
            Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //3


            //initalize fields

            product1.SetProductID(1);
            product1.SetProductName("Laptop");
            product1.SetCost(10000);
            product1.SetQuantityInStock(500);

            product2.SetProductID(2);
            product2.SetProductName("Computer");
            product2.SetCost(400000);
            product2.SetQuantityInStock(400);

            product3.SetProductID(3);
            product3.SetProductName("Phone");
            product3.SetCost(10000);
            product3.SetQuantityInStock(700);

            //call methods
            double f = 9;
            product1.CalculateTax(ref f); //default value assigns
            /* product2.CalculateTax(percentage: 4.9);*/ //named arguments
            product3.CalculateTax(300000, 2.3);


            Console.WriteLine("f is : " + f); //9=>3.7

            //Get values from fields

            Console.WriteLine("Developer Name: " + developerName);
            Console.WriteLine();

            //product1.prroductName output:error *abstractions
            //We are accessing fields through the methods indirectly.Methods must be used to manipulate the fields.
            Console.WriteLine("Product1:");
            Console.WriteLine("Product Id: " + product1.GetProductID());
            Console.WriteLine("Product Name: " + product1.GetProductName());
            Console.WriteLine("Cost: " + product1.GetCost());
            Console.WriteLine("Quantity In Stock: " + product1.GetQuantityInStock());
            Console.WriteLine("Tax: " + product1.GetTax());
            Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
            Console.WriteLine();

            Console.WriteLine("Product2:");
            Console.WriteLine("Product Id: " + product2.GetProductID());
            Console.WriteLine("Product Name: " + product2.GetProductName());
            Console.WriteLine("Cost: " + product2.GetCost());
            Console.WriteLine("Quantity In Stock: " + product2.GetQuantityInStock());
            Console.WriteLine("Tax: " + product2.tax);
            Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
            Console.WriteLine();

            Console.WriteLine("Product3:");
            Console.WriteLine("Product Id: " + product3.GetProductID());
            Console.WriteLine("Product Name: " + product3.GetProductName());
            Console.WriteLine("Cost: " + product3.GetCost());
            Console.WriteLine("Quantity In Stock: " + product3.GetQuantityInStock());
            Console.WriteLine("Tax: " + product3.GetTax());
            Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
            Console.WriteLine();

            //total quantity
            int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);


            //display totals
            Console.WriteLine("Total Quantity: " + totalQuantity);
            //static
            Console.WriteLine("Total no.of products: " + Product.TotalNoProducts); //output:3
            //const 
            Console.WriteLine("Category of products: " + Product.CategoryName); //output:Electronics

            Console.ReadKey();

        }
    }
    //Encapsulation


    public class Product
    {
        //fields
        private string productName;

        public int productID;
        public double cost;

        public double tax;
        public int quantityInStock;

        public static int TotalNoProducts;

        public const string CategoryName = "Electronics";

        public readonly string dateOfPurchase;

        //ref arguments
        public void CalculateTax(ref double percentage)
        {
            percentage = 3.7;
            //create local variable
            double t;

            //calculate tax
            if (cost < 20000)
            {
                t = cost * 10 / 100;
            }
            else
            {
                t = cost * percentage / 100;
            }
            tax = t;

        }
        //Method Overloading
        //second method executes
        public void CalculateTax(double cost, double percentage)
        {
            //create local variable
            double t;

            //calculate tax
            if (cost < 20000)
            {
                t = cost * 10 / 100;
            }
            else
            {
                t = cost * percentage / 100;
            }
            tax = t;

        }

        //constructor
        // we cannot modify the value of the readonly field except in thr constructor
        public Product()
        {
            dateOfPurchase = DateTime.Now.ToShortDateString();
        }
        public string GetDateOfPurchase()
        {
            return dateOfPurchase;
        }

        //Set method for productID

        public void SetProductID(int productID)
        {
            this.productID = productID;
        }

        //Get method for productID
        public int GetProductID()
        {
            return productID;
        }

        //SetGet method for productName
        public void SetProductName(string text)
        {
            productName = text;
        }
        public string GetProductName()
        {
            return productName;
        }

        //Assignment
        public void SetTax(double t)
        {
            tax = t;
        }
        //Returning
        public double GetTax()
        {
            return tax;

        }
        //instance methods
        //default argument
        public void SetCost(double c = 100000)
        {
            cost = c;
        }
        public double GetCost()
        {
            return cost;
        }

        public void SetTotalNoProducts(int value)
        {
            TotalNoProducts = value;
        }
        public int GetTotalNoProducts()
        {
            return TotalNoProducts;
        }

        public void SetQuantityInStock(int value)
        {
            quantityInStock = value;
        }
        public int GetQuantityInStock()
        {
            return quantityInStock;
        }

        //static method
        public static void SetTotalNoOfProducts(int value)
        {
            TotalNoProducts = value;
        }
        public static int GetTotalNoOfProducts()
        {
            return TotalNoProducts;
        }

        //static method: Calculate Total Quantity
        //reference variables *Product product1, *Product product2, *Product product3
        public static int GetTotalQuantity(Product product1, Product product2, Product product3)
        {
            int total;
            total = product1.GetQuantityInStock() + product2.GetQuantityInStock() +
                product3.GetQuantityInStock();
            return total;
        }
    }
}
