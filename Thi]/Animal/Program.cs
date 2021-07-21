using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Console.WriteLine();
            Lion lion = new Lion();

            tiger.Show();
            lion.Show();
        }
    }
}
