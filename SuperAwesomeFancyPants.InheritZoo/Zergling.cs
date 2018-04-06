using System;

namespace SuperAwesomeFancyPants.InheritZoo
{
    public class Zergling : Animal
    {
        public int NumberOfClaws { get; set; } = 2;

        public Zergling()
        {
            Name = "For The Swarm";
            NumberOfLegs = 4;
            Weight = 1;
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