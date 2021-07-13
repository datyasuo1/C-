using System;

namespace task8.ex3
{
    class Program
    {
        
        static void PrintStudentDetails(string first,string last,string birthday)
        {
            Console.WriteLine("{0} {1} was born on {2}", first, last, birthday);
        }
        static void GetStudentInformation()
        {
            
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter birthday");
            string birthday = Console.ReadLine();
        }
        static void Main(string[] args)
        {
           
            GetStudentInformation();
            
        }
    }
}
