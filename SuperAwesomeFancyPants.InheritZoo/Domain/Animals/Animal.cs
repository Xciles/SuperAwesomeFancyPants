using System;
using SuperAwesomeFancyPants.InheritZoo.Business;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; } = 4;
        public int Weight { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsHungry { get; set; }
        public bool IsAlive { get; set; } = true;
        public float AmountOfFoodWhenEating
        {
            get { return Weight / 2.5f; }
        }

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

        protected void GetFoodAndEat<T>()
            where T : IFood
        {
            if (Zoo.Instance().GetFood<T>(AmountOfFoodWhenEating))
            {
                IsHungry = false;
            }
            else
            {
                IsHungry = true;
                // Do something else next iteration
            }
        }
    }
}