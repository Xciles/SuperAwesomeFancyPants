using System;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Mammals
{
    public class Lion : Mammal, ICarnivore
    {
        public Lion(int weight) 
            : base(weight, "Lion")
        {
        }

        public override void Eat()
        {
            EatMeat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawrrrrrrrrr");
            SomeMethodInAnimal();
        }

        public void EatMeat()
        {
            base.GetFoodAndEat<IMeat>();
        }
    }
}