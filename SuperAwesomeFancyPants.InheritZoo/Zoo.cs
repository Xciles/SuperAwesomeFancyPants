using System;
using System.Collections.Generic;

namespace SuperAwesomeFancyPants.InheritZoo
{
    public class Zoo
    {
        private IList<Animal> _animals = new List<Animal>();

        public void FillZoo()
        {
            _animals.Add(new Lion(60));
            _animals.Add(new Lion(14));
            _animals.Add(new Dog(50));

            _animals.Add(new Giraffe(150));
            _animals.Add(new Crocodile(250));
        }

        public void AddLion(int weight)
        {
            _animals.Add(new Lion(weight));
        }

        public void AddZergling()
        {
            _animals.Add(new Zergling());
        }

        public void PrintInfo()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"Type of Animal: {animal.GetType().Name}. " +
                                  $"Name: {animal.Name}, Weight: {animal.Weight}.");
                animal.Eat();
                animal.MakeSound();
            }
        }
    }
}