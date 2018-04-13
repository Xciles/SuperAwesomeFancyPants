using System;
using System.Collections.Generic;
using System.Linq;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Mammals;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Others;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Reptiles;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Business
{
    public class Zoo
    {
        private static Zoo _instance;

        private readonly IList<IAnimal> _animals = new List<IAnimal>();
        private readonly FoodStock _foodStock = new FoodStock();

        protected Zoo()
        {
        }

        public static Zoo Instance()
        {
            if (_instance == null)
            {
                _instance = new Zoo();

            }

            return _instance;
        }

        public void FillZoo()
        {
            _animals.Add(new Lion(60));
            _animals.Add(new Lion(14));
            _animals.Add(new Lion(15));
            _animals.Add(new Lion(156));
            _animals.Add(new Lion(10));
            _animals.Add(new Dog(50));

            _animals.Add(new Giraffe(150));
            _animals.Add(new Giraffe(12));
            _animals.Add(new Giraffe(5));
            _animals.Add(new Giraffe(63));
            _animals.Add(new Giraffe(155));
            _animals.Add(new Giraffe(234));
            _animals.Add(new Crocodile(250));

            _animals.Add(new Terran());
            _animals.Add(new Terran());
            _animals.Add(new Terran());
            _animals.Add(new Terran());
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
            PrintNumberOfAnimals();
            PrintAnimalInfo();
            PrintFoodStock();
        }

        public void Iterate()
        {
            // Check food
            //  No food > murder
            //  No food > die
            // Check alive

            // a comment
            foreach (var animal in _animals)
            {
                if (animal.IsAlive)
                {
                    animal.Eat();
                    Console.WriteLine($"{animal.GetType().Name} IsHungy: {animal.IsHungry}");
                }
            }

            var animalsToRemove = _animals.Where(x => !x.IsAlive).ToList();
            foreach (var animal in animalsToRemove)
            {
                _animals.Remove(animal);
            }
        }

        public void PrintNumberOfAnimals()
        {
            var type = typeof(Animal);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                            .SelectMany(s => s.GetTypes())
                            .Where(p => p.IsSubclassOf(type) && !p.IsAbstract);

            foreach (var typeOfAnimal in types)
            {
                Console.WriteLine($"Animal Type: {typeOfAnimal.Name}, # of Animals for type: {_animals.Count(x => x.GetType() == typeOfAnimal)}");
            }
        }

        private void PrintAnimalInfo()
        {
            Console.WriteLine("Animals in the zoo");
            foreach (var animal in _animals)
            {
                Console.WriteLine($"Type of Animal: {animal.GetType().Name}. " +
                                  $"Name: {animal.Name}, Weight: {animal.Weight}.");
                //Console.Write("Eat: ");
                //animal.Eat();
                Console.Write("Sound: ");
                animal.MakeSound();
            }
        }

        public void PrintFoodStock()
        {
            Console.WriteLine("Print food stock information");
            _foodStock.PrintInfo();
        }

        public bool GetFood<T>(float requiredNumberOfFood)
            where T : IFood
        {
            return _foodStock.RemoveFoodFromStock<T>(requiredNumberOfFood);
        }

        public int GetNumberOfAnimals()
        {
            return _animals.Count;
        }

        public IHerbivore FindHerbivore()
        {
            var herbivore = _animals.OfType<IHerbivore>().FirstOrDefault(x => x.IsAlive);
            if (herbivore != null)
            {
                herbivore.IsAlive = false;
            }

            return herbivore;
        }

        public T Find<T>()
            where T : IAnimal
        {
            var animal = _animals.OfType<T>().FirstOrDefault(x => x.IsAlive);
            if (animal != null)
            {
                animal.IsAlive = false;
            }

            return animal;
        }
    }
}