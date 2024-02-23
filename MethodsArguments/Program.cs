using System;


namespace MethodsArguments
{
    public class Program
    {
        static void Main()
        {
            Sample outSample = new Sample();
            Sample inSample = new Sample();
            //out
            int numArgument = 0;
            Console.WriteLine("numArgument before execution: " + numArgument);
            var result = outSample.ExampleForOut(out numArgument);
            Console.WriteLine("Result of out: " + result);
            Console.WriteLine("numArgument after execution: " + numArgument);
            //new features
            var result2 = outSample.ExampleForOut(out int p);
            Console.WriteLine("p: " + result2);

            //In
            int q = 0;
            var result3 = inSample.ExampleForIn(in q);
            Console.WriteLine("Q is: " + q);
            Console.WriteLine(result3);

            //ref return 
            //creating object of class
            Student student = new Student();
            //call printgrade
            student.PrintGrade(); //output:2
            //call dowork
            ref int g = ref student.DoWork();
            Console.WriteLine("RefReturn Grade before update: " + g); //output:2
            //update value grade
            g = 6;
            student.PrintGrade(); //output:6
            Console.WriteLine("RefReturn Grade after update: " + g); //output:6

            //create objects of Teacher class
            Teacher t = new Teacher();
            //access DisplaySubjects method
            t.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics");

            Console.ReadKey();
        }
    }
    public class Sample
    {
        public int ExampleForOut(out int numParams)
        {
            numParams = 4;  //write-only
            return numParams;

        }
        public int ExampleForIn(in int numParamsIn)
        {
          
            return numParamsIn; //read-only

        }
    }
    public class Student
    {
        //public field
        public int grade = 2;

        //public method
        public void PrintGrade()
        {
            Console.WriteLine("Grade: " + grade);
        }
        //public method with ref return
        public ref int DoWork()
        {
            //return reference of grade field
            return ref grade;
        }
    }
    public class Teacher
    {
        //receive all subjects as an array using 'params' modifier
        public void DisplaySubjects(params string[] subjects)
        {
            Console.WriteLine("First subject: " + subjects[0]);
            foreach (var subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
