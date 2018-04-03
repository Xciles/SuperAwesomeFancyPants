using System;

namespace SuperAwesomeFancyPants
{
    // Access Modifiers
    // private
    // protected
    // public 
    // internal
    public class Door
    {

    }

    public class Program
    {
        private static int _age;
        private static string _hans;
        private static bool _isInEindhoven = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            ////string name = "Hans";
            ////bool inEindhoven = false;
            ////float flo = 1.1f;
            ////double d = 1.1d;
            ////decimal dec;

            ////long a = 922337_2036_854_775_807;
            //////int.MaxValue;
            ////int number;
            ////number = 1234;
            ////number = 43321;

            //////int age = 30;
            //////age = AddFive(age);

            ////_age = 30;

            //// Write something to Console
            //Console.WriteLine("Hello Yacht, " + name + ". Welcome");
            //Console.WriteLine($"Hello Yacht, {name}. {_age}");

            Car car = new Car();
            
            car.AddAmmountOfFuel(50.0f);
            float carFuel = car.Fuel;

            Car anotherCar = new Car(25f);

            Console.ReadKey();
        }

        public static int AddFive(int value)
        {
            _age += 5;
            value += 5;
            return value;
        }
    }
}
