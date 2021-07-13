using System;

namespace Task8
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //   Sum(20, 40);
        //}
        //static void Sum(int first, int second)
        // {
        //    int sum = first + second;
        //     Console.WriteLine($"The sum of {first}and{second} is:{sum}");
        //}
        
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Sum(int first, int second,int third)
        {
            int sum = first + second+third;
            return sum;
        }
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with tow argument, result is :{result}");

            int result2 = Sum(10, 20, 30);
            Console.WriteLine($"Calling Sum() with three argument, result is :{result2}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that tskes double result in, result is :{dblResult}");


        }
    }
}
