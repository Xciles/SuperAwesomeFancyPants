using System;
using System.Collections.Generic;
using System.Linq;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Mammals;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Others;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Reptiles;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Business
{
    public class Zoo
    {
        private static Zoo _instance;



        private readonly IList<Animal> _animals = new List<Animal>();
        private FoodStock _foodStock = new FoodStock();

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
                animal.Eat();
                Console.WriteLine($"{animal.GetType().Name} IsHungy: {animal.IsHungry}");
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
    }
}