using System;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Mammals
{
    public class Dog : Mammal, ICarnivore
    {
        public Dog(int weight)
            : base (weight, "Yes, this is Dog?")
        {
        }

        public override void Eat()
        {
            EatMeat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woef");
        }

        public void EatMeat()
        {
            base.GetFoodAndEat<IMeat>();
            IsAlive = !IsHungry;
        }
    }
}