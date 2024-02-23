using System;
class Number
{
    private int value; //field
    public void SetValue(int value)
    {
        this.value = value; //current object
    }
    public double GetValue()
    {
        return value;
    }
    public bool IsZero(int num)
    {
        if (num == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsPositive(int num)
    {
        if (num > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsNegative(int num)
    {
        if (num < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsOdd(int num)
    {
        if (num % 2 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsEven(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsPrime()
    {

        int control = 0;
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                control++;
        }

        if (control != 0)

            return false;
        else
            return true;
    }


    public static int Power(int baseNumber, int exponent, bool recursive = true)
    {

        int result = 1;
        if (recursive == false)
        {
            for (int i = 0; i <= exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
        else
        {
            if (exponent == 0) //base case
            {
                return 1;
            }
            else //recursive case
            {
                return baseNumber * Power(baseNumber, exponent - 1);
            }

        }

    }

}
class Program
{
    static void Main()
    {
        Number number = new Number();
        number.SetValue(371); //you can set any integer value
        Console.WriteLine("Value: " + number.GetValue()); //Output: 371
        Console.WriteLine("IsZero: " + number.IsZero(1)); //Output: False
        Console.WriteLine("IsPositive: " + number.IsPositive(4)); //Output: True
        Console.WriteLine("IsNegative: " + number.IsNegative(3)); //Output: False
        Console.WriteLine("IsOdd: " + number.IsOdd(5)); //Output: True
        Console.WriteLine("IsEven: " + number.IsEven(5)); //Output: False
        Console.WriteLine("IsPrime: " + number.IsPrime()); //Output: False
        Console.WriteLine("Power of number: " + Number.Power(2, 3, true));

        Console.ReadKey();
    }
}