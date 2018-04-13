using System;
using SuperAwesomeFancyPants.InheritZoo.Business;
using SuperAwesomeFancyPants.InheritZoo.Domain.Animals.Interfaces;

namespace SuperAwesomeFancyPants.InheritZoo.Extensions
{
    public static class ZergExtensions
    {
        public static bool EatActualTerran(this IZerg zerg)
        {
            var terran = Zoo.Instance().Find<ITerran>();

            if (terran != null)
            {
                Console.WriteLine($"{zerg.Name} ate {terran.Name}");
                zerg.IsHungry = false;
                return true;
            }
            else
            {
                zerg.IsHungry = true;
            }

            return false;
        }
    }
}