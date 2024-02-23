using System;


class Student
{
    //local function
    public void DisplayMarks(int mark1, int mark2, int mark3)
    {
        double avgMarks = getAvarageMarks();  //this keyword cannot be used
        Console.WriteLine("Mark 1: " + mark1);
        Console.WriteLine("Mark 2: " + mark2);
        Console.WriteLine("Mark 3: " + mark3);
        Console.WriteLine("Avarage of marks: " + avgMarks);
        Console.ReadKey();

        //create local function
        double getAvarageMarks()
        {
            //create local variable of local function
            double avg;
            avg = (double)(mark1 + mark2 + mark3) / 3;
            return avg;
        }

    }
    //static local function
    public void DisplayNumberOfClass(int class1, int class2, int class3)
    {
        double avgClass = getAvarageNumberOfClass(class1, class2, class3);
        Console.WriteLine("Class 1: " + class1);
        Console.WriteLine("Class 2: " + class2);
        Console.WriteLine("Class 3: " + class3);
        Console.WriteLine("Avarage of class members: " + avgClass);
        Console.ReadKey();

        static double getAvarageNumberOfClass(int c1, int c2, int c3)
        {
            double avg;
            avg = (c1 + c2 + c3) / 3;
            return avg;
        }
    }
}
class Program
{
    static void Main()
    {
        //create object of class
        Student s = new Student();
        //call method
        s.DisplayMarks(80, 41, 70);

        s.DisplayNumberOfClass(100,90,78);
    }
}