using System;


namespace PatternPrinting
{
    public class Program
    {
        static void Main()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.Write(i);
                Console.Write(" ");
                i++;
            }
            Console.WriteLine();

            for (int j = 1; j <= 10; j++)
            {
                Console.Write(j);
                Console.Write(" ");
            }
            Console.WriteLine();

            int a = 1;
            do
            {
                Console.Write(a);
                Console.Write(" ");
                a++;
            }
            while (a <= 10);
            Console.WriteLine();


            for (int x = 10; x >= 1; x--)
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.WriteLine();

            int y = 10;
            while (y >= 1)
            {
                Console.Write(y);
                Console.Write(" ");
                y--;
            }
            Console.WriteLine();

            for (int j = 10; j > 0; j--)
            {
                if (j == 2)
                {
                    break;
                }
                Console.Write(j);
                Console.Write(" ");
            }
            Console.WriteLine();

            goto myLabel;
            Console.Write(0);
        myLabel:
            Console.Write(10 + " ");
            Console.Write(9 + " ");
            Console.Write(8 + " ");
            Console.Write(7 + " ");
            Console.Write(6 + " ");
            Console.Write(5 + " ");
            Console.Write(4 + " ");
            Console.Write(3 + " ");
            Console.Write(2 + " ");
            Console.Write(1 + " ");
            Console.WriteLine();

            for (int j = 1; j <= 10; j++)
            {
                if (j == 8)
                {
                    continue;
                }
                Console.Write(j);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

