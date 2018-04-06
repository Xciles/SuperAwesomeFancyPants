using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; } = 4;
        public int Weight { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public abstract void Eat();
        public abstract void MakeSound();

        protected void SomeMethodInAnimal()
        {
            Console.WriteLine("Some Method in Animal");
        }

        public void Fight(Animal animalToFightWith)
        {
            throw new NotImplementedException();
        }
    }
}