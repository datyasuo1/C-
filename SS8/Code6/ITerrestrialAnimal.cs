using System;

namespace Code6
{
    interface ITerrestrialAnimal
    {
        void Eat();
    }
    interface IMarinelAnimal
    {
        void Swim();
    }
    class Crocodile:ITerrestrialAnimal, IMarinelAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Crocodile eats flesh");
        }
        public void Swim()
        {
            Console.WriteLine("The Crocodile can swim four times faster than an Olympic swimmer");
        }
        static void Main(string[] args)
        {
            Crocodile objCrocodile = new Crocodile();
            objCrocodile.Eat();
            objCrocodile.Swim();
        }
    }
}
