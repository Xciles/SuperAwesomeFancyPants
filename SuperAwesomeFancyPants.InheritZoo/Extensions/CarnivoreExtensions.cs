using System;
using SuperAwesomeFancyPants.InheritZoo.Business;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Extensions
{
    public static class CarnivoreExtensions
    {
        public static bool FightHerbivore(this ICarnivore carnivore)
        {
            var herbivore = Zoo.Instance().FindHerbivore();

            if (herbivore != null)
            {
                Console.WriteLine($"{carnivore.Name} ate {herbivore.Name}");
                carnivore.IsHungry = false;
                return true;
            }

            return false;
        }
    }
}
