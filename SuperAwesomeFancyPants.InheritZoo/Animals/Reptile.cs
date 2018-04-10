using System;

namespace SuperAwesomeFancyPants.InheritZoo.Animals
{
    public abstract class Reptile : Animal
    {
        public int NumberOfEggs { get; set; }

        protected Reptile() { }

        protected Reptile(int weight, string name = null)
            : base(weight, name) { }

        protected Reptile(int weight, DateTime date, string name = null)
            : base(weight, date, name) { }
    }
}