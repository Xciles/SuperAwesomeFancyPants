using System;

namespace SuperAwesomeFancyPants.PracticeQuestions
{




    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Program obj = null;
    //        Console.WriteLine(Program.print());
    //    }
    //    private static String print()
    //    {
    //        return "Hi, I am a Tech-savvy!!";
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        int[] i = new int[0];
    //        Console.WriteLine(i[0]);
    //    }
    //}

    //public class Program
    //{
    //    public const string MyConst = "MyConst";
    //    public static string MyStatic { get; set; } = "MyStatic";
    //    public readonly string MyReadOnly = "MyReadOnly";

    //    public static void Main(string[] args)
    //    {
    //        Program.MyConst = "Something else with Const";
    //        Program.MyStatic = "Something else with Static";
    //    }
    //}

    //public class WhatEver
    //{
    //    public void Thing()
    //    {
    //        Program.MyConst;
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        var name = "Hans";
    //        var age = 10;
    //        Console.WriteLine("I am a {name} and my mental age is {age}");
    //    }
    //}

    //public class Animal
    //{
    //    public int NumberOfLegs { get; set; } = 10;
    //}

    //public class Mammal : Animal
    //{
    //    public Mammal()
    //    {
    //        NumberOfLegs = 4;
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Animal animal = new Mammal();
    //        Console.WriteLine($"I am a {animal.GetType().Name} and I have {animal.NumberOfLegs} legs");
    //    }
    //}

    //public class Animal
    //{
    //    public void PrintSomething()
    //    {
    //        Console.WriteLine("Printing something from Animal");
    //    }
    //}

    //public class Mammal : Animal
    //{
    //    public void PrintSomething()
    //    {
    //        Console.WriteLine("Printing something from Mammal");
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Animal animal = new Mammal();
    //        animal.PrintSomething();
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        int i = 1;
    //        Console.Write(i);
    //        Console.Write(i++);
    //        Console.Write(--i);
    //    }
    //}

    public class Program
    {
        public static void Main(string[] args)
        {
            MyMethod();
        }

        private static void MyMethod()
        {
            Console.WriteLine("Calling MyMethod");
            MyMethod();
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        var var = "myString";

    //        Console.WriteLine("Will it build, that is the question?!");
    //        Console.WriteLine($"Output: {var}");
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        string string = "myString";

    //        Console.WriteLine("Will it build, that is the question?!");
    //        Console.WriteLine($"Output: {String}");
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        try
    //        {
    //            throw new NullReferenceException();
    //        }
    //        catch (NullReferenceException)
    //        {
    //            Console.Write("A");
    //        }
    //        catch (Exception)
    //        {
    //            Console.Write("B");
    //        }
    //        finally
    //        {
    //            Console.Write("C");
    //        }
    //    }
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        string myString = "Hello";
    //        int myInt = int.Parse("1234");

    //        Console.WriteLine($"{myString} there! {myInt}");
    //    }
    //}
}
