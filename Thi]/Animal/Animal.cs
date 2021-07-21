using System;

namespace Animal
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public void SetMe(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
        }
    }
}

