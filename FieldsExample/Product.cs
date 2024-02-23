using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //static fields : allocated only once for the entire program
        public static int NumberOfProducts { get; set; }

        //const fields : cannot be modified value      
        public const string CategoryName = "Electronics";

        //readonly fields is like instance fields, that is stored in every object,individually
        //Value cannot be changed
        public readonly int CategoryId = 1;
    }
}
