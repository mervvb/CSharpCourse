using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    public class Program
    {
        static void Main()
        {
            //implicit casting

            //sbyte
            sbyte a = 10;

            //int
            int b;

            //copy the value from 'a' to 'b'
            b = a;
            Console.WriteLine(b); //output:10
            Console.WriteLine(a); //output:10

            //char 
            char c = 'a';

            //int 
            int d;

            //copy the value from 'c' to 'd'
            d = c;

            Console.WriteLine(d); //output:97
            Console.WriteLine(c); //output:a


            //explicit casting

            //int
            int e = 100;

            //float
            float f;

            //int to float
            f = (float)e;

            Console.WriteLine(e); //output:100
            Console.WriteLine(f); //output:100


            //loosy conversion
            long x = 200;

            sbyte y;

            y = (sbyte)x;

            Console.WriteLine(y);  //output:-56

            //parsing

            //string
            string textnum = "100";

            //int
            int num;

            //string to int
            num = int.Parse(textnum);

            Console.WriteLine(textnum); //100 as string
            Console.WriteLine(num);  //100 as int


            //read input value from keyboard
            string s;
            Console.Write("Enter a number: ");
            s = Console.ReadLine();

            //tryparse       
            bool valid = int.TryParse(s, out int n);

            if (valid == true)
            {
                Console.WriteLine("Conversion is successful.");
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("THe input isn't convertible.");
            }

            //conversion methods

            char charNum = 'A';
            int intNum = Convert.ToInt32(charNum);
            Console.WriteLine(intNum);

            Console.ReadKey();
        }
    }
}
