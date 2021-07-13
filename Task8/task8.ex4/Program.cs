using System;

namespace task8.ex4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var emp = new TechnicalEmployee("kaka");
            var emp1 = new BusinessEmployee("Winter");
            Console.WriteLine( emp.employeeStatus() + "..." + emp1.employeeStatus());
        }
    }
}
