using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals.Others
{
    public class Zergling : Mammal
    {
        public int NumberOfClaws { get; set; } = 2;

        public Zergling()
            : base (1, "For The Swarm")
        {
            NumberOfLegs = 4;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating some nice 'Terran' skum");
        }

        public override void MakeSound()
        {
            Console.WriteLine("IYguywgeruywegr");
        }
    }
}