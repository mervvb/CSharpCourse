using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Program
    {
        static void Main()
        {
            //reference variables
            Customer c1,c2;
            
            //objects
            c1=new Customer { name = "Merv", age = 23};
            c2=new Customer();
        }
    }
    public class Customer
    {
        public string name;
        public int age;
    }

}
