using System;
using System.Reflection.Emit;

namespace ControlStatements
{
    public class Program
    {
        static void Main()
        {
            //IfElse();
            //SwitchCase();
            //While();
            //DoWhile();
            //For();
            //Break();
            //Continue();
            //NestedFor();
            //Goto();
        }
        private static void Goto()
        {
            Console.WriteLine("A");
            goto myLabel;
            Console.WriteLine("B");
            Console.WriteLine("C");
        myLabel:
            Console.WriteLine("D");
            Console.WriteLine("E");
            Console.WriteLine("F");
            Console.ReadKey();
            //Output: A,D,E,F
        }

        private static void NestedFor()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void Continue()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 8)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        private static void Break()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine(i);
                //Output = 0,1,2,3,4,5
            }
            Console.ReadKey();
        }

        private static void For()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        private static void DoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 0);
            Console.ReadKey();
        }

        private static void While()
        {
            //initialization
            // 1 to 10
            int i = 1;
            while (i <= 10)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();


            // 0 to 9
            i = 0;
            while (i < 10)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();


            // 9 to 0
            i = 9;
            while (i >= 0)
            {
                Console.Write(i + " ");
                i--;
            }


            Console.ReadKey();
        }

        private static void SwitchCase()
        {
            //variable to store grade letter of student
            char gradeLetter = 'A';
            //find out description based on gradeLetter
            string gradeDescription;
            switch (gradeLetter)
            {
                case 'O': gradeDescription = "Outstanding"; break;
                case 'A': gradeDescription = "Excellent"; break;
                case 'B': gradeDescription = "Good"; break;
                case 'C': gradeDescription = "Average"; break;
                case 'F': gradeDescription = "Fail"; break;
                default: gradeDescription = "None"; break;

            }
            Console.WriteLine(gradeDescription);
            Console.ReadLine();
        }

        private static void IfElse()
        {
            int number = 5;
            if (number > 5)
            {
                Console.WriteLine("The number is bigger than 5.");

            }
            else if (number == 5)
            {
                Console.WriteLine("The number is equal to 5.");
            }
            else
            {
                Console.WriteLine("The number is smaller than 5.");

            }
        }
    }
}
