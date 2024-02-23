using System;

namespace TypeConversionDemo
{
    internal class Program
    {
        static void Main()
        {
            //implicit
            byte a = 10;
            short s;
            s = a;
            Console.WriteLine(s);
            Console.WriteLine(a);

            //explicit
            int b = 10;
            short k;
            k = (short)b;
            Console.WriteLine(k);
            Console.WriteLine(b);

            //Parse
            string c = "10.34";
            double cParse;
            cParse = double.Parse(c);
            Console.WriteLine(cParse);  //double
            Console.WriteLine(c);  //string

            //TryParse
            string e = "10.34";
            bool valid;
            valid = decimal.TryParse(e, out decimal eTryParse);
            if (valid == true)
            {
                Console.WriteLine(eTryParse);
            }
            else
            {
                Console.WriteLine("Invalid.");
            }

            //conversion methods
            Console.Write("Enter a number: ");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            string numText = Convert.ToString(d);
            Console.WriteLine(numText);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
