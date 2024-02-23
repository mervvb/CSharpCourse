
using System;
class Sample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1); //recursion
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num;
        num = int.Parse(Console.ReadLine());
        Sample sample = new Sample();
        var result = sample.Factorial(num);
        Console.WriteLine("Factorial of " + num + " is" + result);
        Console.ReadLine();

        //num = 4
        /*
         * Factorial(4) = 4 * Factorial(3)
         * Factorial(3) = 3 * Factorial(2)
         * Factorial(2) = 2 * Factorial(1)
         * Factorial(1) = 1 * Factorial(0)
         * Factorial(0) = 1
         */
    }
}