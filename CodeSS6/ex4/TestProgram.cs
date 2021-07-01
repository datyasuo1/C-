using System;

namespace ex4
{
    class TestProgram
    {
        void Count(int boys, int girls)
        {
            Console.WriteLine(boys + girls);
        }
        static void Main(string[] args)
        {
            TestProgram objTest = new TestProgram();
            objTest.Count(boys: 16, girls: 24);
        }
    }
}
