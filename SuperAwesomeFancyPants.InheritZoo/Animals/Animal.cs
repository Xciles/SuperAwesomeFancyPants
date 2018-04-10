﻿using System;
using SuperAwesomeFancyPants.InheritZoo.Animals.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; } = 4;
        public int Weight { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        protected Animal() { }

        protected Animal(int weight, string name = null)
            : this(weight, DateTime.Now, name) { }

        protected Animal(int weight, DateTime date, string name = null)
        {
            Weight = weight;
            Name = name;
            Date = date;
        }

        public abstract void Eat();
        public abstract void MakeSound();

        protected void SomeMethodInAnimal()
        {
            Console.WriteLine("Some Method in Animal");
        }
    }
}