using System;

namespace SuperAwesomeFancyPants.InheritZoo.Domain.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal() { }

        protected Mammal(int weight, string name = null)
            : base(weight, name) { }

        protected Mammal(int weight, DateTime date, string name = null)
            : base(weight, date, name) { }

        public int NumberOfChildernInWomb { get; set; }
    }
}