using System;

namespace SuperAwesomeFancyPants.InheritZoo
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public int Weight { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Base Eating");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Base Sound");
        }

        protected void SomeMethodInAnimal()
        {
            Console.WriteLine("Some Method in Animal");
        }
    }
}