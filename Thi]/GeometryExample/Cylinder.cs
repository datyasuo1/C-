using System;

namespace GeometryExample
{
   
    class Cylinder
    {
        static void Main(string[] args)
        {
            Result();
        }
        static void Process(double radius, double height)
        {
            double BaseArea = radius * radius * Math.PI;
            double LateralArea = 2 * Math.PI * radius * height;
            double TotalArea = 2 * Math.PI * radius * (height + radius);
            double Volume = Math.PI * radius * radius * height;
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Base: " + BaseArea);
            Console.WriteLine("Lateral: " + LateralArea);
            Console.WriteLine("Total: " + TotalArea);
            Console.WriteLine("Volume: " + Volume);
        }

        static void Result()
        {
            Console.WriteLine("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            double height = double.Parse(Console.ReadLine());
            Process(radius, height);
        }
    }
}
   
