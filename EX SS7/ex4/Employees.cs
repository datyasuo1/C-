using System;

namespace ex4
{
    class Employees
    {
        int _empID = 1;
        string _empName = "Jame Anderson";
        int _age = 25;
        public void Display()

        {
            Console.WriteLine("Employee ID:" + _empID);
            Console.WriteLine("Employee Name:" + _empName);
        }
    }
    class Deparment:Employees
    {
        int _depId = 501;
        string _depName = "Sale";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Deparment ID:" + _depId);
            Console.WriteLine("Deparment Name:" + _depName);
        }
        static void Main(string[]args)
        {
            Deparment objDeparment = new Deparment();
            objDeparment.Display();
        }
    }
}
