using System;

namespace Task8.ex2
{
    class Program
    {
       // static void Main(string[] args)
       // {

       //     int result = Divide(2, 0);
       // }
        static int Divide(int first,int second) 
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero,please provide a non-zero value for your second value");

            }
            return result;
        }
       static void Main (string[]args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number:");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result of driving{first} by {second} is {result}");
        }
    }
}
