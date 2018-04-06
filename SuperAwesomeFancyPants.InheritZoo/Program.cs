using System;
using System.Collections;

namespace SuperAwesomeFancyPants.InheritZoo
{
    /// <summary>
    /// Create a Zoo that contains various animals.
    /// The Zoo contains a list of animals and will manage interaction.
    /// 
    /// Create a couple of Animals that share things via inheritance.
    /// Examples are: (But you can choose something different yourself (e.g.Zergling, Hydra etc))
    /// - A basetype Animal
    /// - A basetype Mammal, Reptile, etc
    /// - Actual Types based on Mammal, Reptile etc.
    /// 
    /// Give those classes some fields and method that they share (for example): 
    /// - MakeSound
    /// - Eat
    /// - NumberOfLegs
    /// - Weight
    /// - ChildrenInWomb
    /// 
    /// If you can think of different things they can share, feel free.
    /// 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.FillZoo();
            zoo.PrintInfo();

            zoo.AddLion(111);

            zoo.PrintInfo();

            zoo.AddZergling();
            zoo.AddZergling();
            zoo.AddZergling();
            zoo.AddZergling();
            zoo.AddZergling();
            zoo.AddZergling();

            zoo.PrintInfo();


            Console.ReadKey();
        }
    }
}
