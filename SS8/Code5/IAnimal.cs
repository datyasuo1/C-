using System;

namespace Code5
{
    interface IAnimal
    {
        void Habitat();
    }
    class Dog:IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Canbe housed with human beings");
        }
        static void Main(string[]args)
        {
            Dog objDog = new Dog();
            Console.WriteLine(objDog.GetType().Name);
            objDog.Habitat();
        }
    }
}
