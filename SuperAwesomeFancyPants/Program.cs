using System;

namespace SuperAwesomeFancyPants
{
    public class CarT
    {
        //private const int _maxSpeed = 184;
        private int _maxSpeed = 184;
        //private static readonly int _maxSpeed = 184;

        public float Fuel { get; set; }

        //static CarT()
        //{
        //    _maxSpeed = 140;
        //}

        public CarT()
        {
            Fuel = 40f;
        }

        public CarT(float initialFuel, int maxSpeed)
        {
            Fuel = initialFuel;
            _maxSpeed = maxSpeed;
        }

        ~CarT()
        {
        }

        public void AddSomeFuel(float fuelToAdd)
        {
            Fuel += fuelToAdd;
            _maxSpeed += 1;
            _maxSpeed = _maxSpeed + 1;
            _maxSpeed--;
        }

        public static void CallSomthingOnCar()
        {

        }
    }

    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int number = 1234;
            string numberAsString = number.ToString();

            int index = 1;

            Console.WriteLine(index); // 1
            Console.WriteLine(index++); // 1 = 2
            Console.WriteLine(++index); // 3

            int age = 16;

            //if (true)
            if (age >= 10 && age <= 15)
            {

            }

            if (age != 16)
            {

            }

            string input = Console.ReadLine();
            //if (input == null || input == "")
            bool isNullOrEmpty = string.IsNullOrEmpty(input);
            //if (!isNullOrEmpty)
            if (!string.IsNullOrEmpty(input))
            {
                // if true do this
                //Console.WriteLine("The string is empty");
                Console.WriteLine($"The string contains: {input}");
            }


            if (input == "test")
            {
                Console.WriteLine("It equals test!");
            }
            else if (input.Contains("yacht"))
            {
                Console.WriteLine("It equals Yacht!");
            }
            else
            {
                Console.WriteLine("It doesn't contain anything!");
            }

            CarT car = new CarT();
            car.AddSomeFuel(10f);
            

            CarT secondCar = new CarT(20f, 150);

            IncreaseFuel(car);

            int result = Sum(10, 20);

            Console.WriteLine("Program end!");
            Console.ReadKey();
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        private static float Sum(float x, float y)
        {
            return x + y;
        }

        private static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static void IncreaseFuel(CarT car)
        {
            car.Fuel += 10;
        }
    }
}

//using System;

//namespace SuperAwesomeFancyPants
//{
//    // Access Modifiers
//    // private
//    // protected
//    // public 
//    // internal
//    public class Door
//    {

//    }

//    public class Program
//    {
//        private static int _age;
//        private static string _hans;
//        private static bool _isInEindhoven = false;

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="args"></param>
//        public static void Main(string[] args)
//        {
//            ////string name = "Hans";
//            ////bool inEindhoven = false;
//            ////float flo = 1.1f;
//            ////double d = 1.1d;
//            ////decimal dec;

//            ////long a = 922337_2036_854_775_807;
//            //////int.MaxValue;
//            ////int number;
//            ////number = 1234;
//            ////number = 43321;

//            //////int age = 30;
//            //////age = AddFive(age);

//            ////_age = 30;

//            //// Write something to Console
//            //Console.WriteLine("Hello Yacht, " + name + ". Welcome");
//            //Console.WriteLine($"Hello Yacht, {name}. {_age}");

//            Car car = new Car();
            
//            car.AddAmmountOfFuel(50.0f);
//            float carFuel = car.Fuel;

//            Car anotherCar = new Car(25f);

//            Console.ReadKey();
//        }

//        public static int AddFive(int value)
//        {
//            _age += 5;
//            value += 5;
//            return value;
//        }
//    }
//}
