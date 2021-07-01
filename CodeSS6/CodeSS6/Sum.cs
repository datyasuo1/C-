using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    class Sum
    {
        int Add (int numOne, int numTwo)
        {
            int addResult = numOne + numTwo;
            Console.WriteLine("Addition = " + addResult);
        }
        static void Main(string[] args)
        {
            Sum objSum = new Sum();
            objSum.Add();
        }
    }
}
