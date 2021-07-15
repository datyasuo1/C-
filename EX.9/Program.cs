using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Issues with Non-generic Collections****\n");
            UsePersonCollection();
            Console.WriteLine();
            UseGenericList();

            Console.ReadLine();
        }
        private static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;

            object boxedInt = myInt;

            try
            {
                long unboxedInt = (long)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            Console.WriteLine();
        }
        static void ArrayListofrandomobjects()
        {
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
        static void UsePersonCollection()
        {
            Console.WriteLine("***Custom Person Collection****");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Code", "Lean", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
            foreach (Person p in myPeople)
                Console.WriteLine(p);
        }
        static void UseGenericList()
        {
            Console.WriteLine("****Fun with Generics*****\n");
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            Console.WriteLine(moreInts[0]+moreInts[1]);
        }
    }
}
