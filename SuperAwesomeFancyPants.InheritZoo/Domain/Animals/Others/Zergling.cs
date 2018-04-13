using System;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Domain.Food.Interfaces;
using SuperAwesomeFancyPants.InheritZoo.Extensions;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Others
{
    public class Terran : Mammal, ITerran
    {
        public override void Eat()
        {
            EatGrass();
        }

        public override void MakeSound()
        {
            Console.WriteLine("TIme to w/e");
        }

        public void EatGrass()
        {
            base.GetFoodAndEat<IPlant>();
        }
    }
    public class Zergling : Mammal, IZerg
    {
        public int NumberOfClaws { get; set; } = 2;

        public Zergling()
            : base(1, "For The Swarm")
        {
            NumberOfLegs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some nice 'Terran' skum");
            EatTerran();
        }

        public override void MakeSound()
        {
            Console.WriteLine("IYguywgeruywegr");
        }

        public void EatTerran()
        {
            this.EatActualTerran();
            IsAlive = !IsHungry;
        }
    }
}