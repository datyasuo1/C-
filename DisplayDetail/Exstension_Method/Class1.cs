using System;
using System.Collections.Generic;
using System.Text;

namespace Exstension_Method
{
    class Class1
    {
        static void Main(string[]args)
        {
            House londonHouse =
                new House { HouseName = "London Street", Members = 3 };
            Console.WriteLine("House Name: {0},Members:{2}",
                londonHouse.HouseName, londonHouse.Members);
        }
    }
}
