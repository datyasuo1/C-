﻿using System;

namespace session7
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
    }
    class Mammal:Animal
    {
        public void Feature ()
        {
            Console.WriteLine("Mammal give birth to yuong ones");
        }
    }
    class Dog:Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks.");
        }
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
}
