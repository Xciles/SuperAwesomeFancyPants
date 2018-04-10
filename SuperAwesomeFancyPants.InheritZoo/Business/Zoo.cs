using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using SuperAwesomeFancyPants.InheritZoo.Animals;
using SuperAwesomeFancyPants.InheritZoo.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Animals.Mammals;
using SuperAwesomeFancyPants.InheritZoo.Animals.Others;
using SuperAwesomeFancyPants.InheritZoo.Animals.Reptiles;
using SuperAwesomeFancyPants.InheritZoo.Extensions;

namespace SuperAwesomeFancyPants.InheritZoo.Business
{
    public class Zoo
    {
        private IList<Animal> _animals = new List<Animal>();

        private bool TrySum(int x, int y, out int outValue)
        {
            outValue = -1;
            try
            {
                outValue = x + y;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public void FillZoo()
        {
            //int outValue;
            //var result = TrySum(5, 5, out outValue);
            //if (TrySum(5, 5, out outValue))
            //{

            //}

            //Animal animal = new Lion(1);

            //string st = "thing";

            ////Lion lion = (Lion) animal;
            //Lion lion = animal as Lion;
            //if (lion == null)
            //{

            //}

            //string number = "thing";
            //int iNumber = Convert.ToInt32(number);

            //int.TryParse(number, out int parseResult);


            //int i = 123;
            //long l = i;
            ////short s = i;

            //double d = 123.1;
            //int di = (int) d;


            _animals.Add(new Lion(60));
            _animals.Add(new Lion(14));
            _animals.Add(new Dog(50));

            _animals.Add(new Giraffe(150));
            _animals.Add(new Crocodile(250));
            //_animals.Count
            var numberOfLions = _animals.NumberOfMammals<Animal,Lion>();

            if (_animals.Any())
            if (_animals.Count == 0)
            {

            }

            var listFor = new List<Animal>();
            foreach (var animal in _animals)
            {
                if (animal.Weight > 10)
                {
                    listFor.Add(animal);
                }
            }

            var list = _animals.Where(animal => animal.Weight > 10).ToList();

            var listQ = (from animal in _animals
                        where animal.Weight > 10
                        select animal);

            _animals.FirstOrDefault();

            var lions = _animals.OfType<IHerbivore>();
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

                if (animal is IHerbivore herbivore)
                {
                    herbivore.EatGrass();
                }
            }
        }
    }
}