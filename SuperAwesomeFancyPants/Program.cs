using System;
using System.Collections.Generic;

namespace SuperAwesomeFancyPants
{
    public class ToDo
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public EActivityType ActivityType { get; set; }

        public ToDo()
        {
            Date = DateTime.Now;
        }

        public ToDo(string name, EActivityType activityType)
            : this(name, DateTime.Now, activityType)
        {
        }

        public ToDo(string name, DateTime date, EActivityType activityType)
        {
            Name = name;
            Date = date;
            ActivityType = activityType;
        }
    }

    public enum EActivityType
    {
        Drive = 1,
        Programming = 2,
        Gaming = 3,
        Fitness = 0
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine($"{date.Year} {date.Month} {date.Day}");
            Console.WriteLine($"{DateTime.Now.Year} {DateTime.Now.Month} {DateTime.Now.Day}");
            Console.WriteLine($"{date.ToLongDateString()}");

            List<ToDo> todos = new List<ToDo>();
            todos.Add(new ToDo("Gaming", DateTime.Now.AddHours(12), EActivityType.Gaming));
            todos.Add(new ToDo("Programming", DateTime.Now.AddHours(24), EActivityType.Programming));

            foreach (ToDo todo in todos)
            {
                if (todo.ActivityType == EActivityType.Gaming)
                {
                    break;
                }
                //if (todo.ActivityType == EActivityType.Gaming)
                //{

                //}
                //else if (todo.ActivityType == EActivityType.Programming)
                //{

                //}
                //else if (todo.ActivityType == EActivityType.Drive)
                //{

                //}
                //else if (todo.ActivityType == EActivityType.Fitness)
                //{

                //}

                //switch (todo.Name)
                //{
                //    case "Something":
                //    {
                //        Console.WriteLine("You have to somehting");
                //    }
                //}

                //switch (todo.ActivityType)
                //{
                //    case EActivityType.Gaming:
                //        {
                //            Console.WriteLine("Gaming");
                //            break;
                //        }
                //    case EActivityType.Programming:
                //        {
                //            Console.WriteLine("Programming");
                //            break;
                //        }
                //    case EActivityType.Fitness:
                //    case EActivityType.Drive:
                //        {
                //            Console.WriteLine("THis is just wasted time");
                //        }
                //    default:
                //        {
                //            Console.WriteLine("Default");
                //        }
                //}
            }

            Console.ReadKey();
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace SuperAwesomeFancyPants
//{
//    public class Program
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="args"></param>
//        public static void Main(string[] args)
//        {
//            string[] listOfWords = new string[] { "list", "car", "fuel", "road" };
//            string[] arrayOfWords = new string[4];
//            //                                      0       1       2       3

//            listOfWords[0] = "not a list";
//            if (listOfWords[0] == "not a list")
//            {

//            }

//            List<string> list = new List<string>();
//            list.Add("list");
//            list.Add("car");
//            list.Add("fuel");
//            list.Add("road");

//            list[0] = "not a list";

//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.WriteLine(list[i]);
//            }

//            int index = 0;
//            while (index < list.Count)
//            {
//                Console.WriteLine(list[index]);
//                index++;
//            }

//            foreach (string str in list)
//            {
//                Console.WriteLine(str);
//            }

//            List<Car> listOfCars = new List<Car>();
//            listOfCars.Add(new Car(10f, 10));
//            listOfCars.Add(new Car());
//            listOfCars.Add(new Car());

//            foreach (Car car in listOfCars)
//            {
//                Console.WriteLine(car.Fuel);
//            }
//        }
//    }
//}

//using System;

//namespace SuperAwesomeFancyPants
//{
//    public class Program
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="args"></param>
//        public static void Main(string[] args)
//        {
//            int zero = 0;
//            int number2 = 0;

//            try
//            {
//                number2 = 1234 / zero;

//                number2++;
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("We tried to divde by 0");

//                number2 = 0;
//            }
//            finally
//            {
//                Console.WriteLine("This is the finally");
//            }

//            Car negCar = new Car();
//            try
//            {
//                negCar.AddSomeFuel(-10f);
//            }
//            catch (FuelNegativeException)
//            {
//                Console.WriteLine("Negative fuel");
//            }

//            int number = 1234;
//            string numberAsString = number.ToString();

//            int index = 1;

//            Console.WriteLine(index); // 1
//            Console.WriteLine(index++); // 1 = 2
//            Console.WriteLine(++index); // 3

//            int age = 16;

//            //if (true)
//            if (age >= 10 && age <= 15)
//            {

//            }

//            if (age != 16)
//            {

//            }

//            string input = Console.ReadLine();
//            //if (input == null || input == "")
//            bool isNullOrEmpty = string.IsNullOrEmpty(input);
//            //if (!isNullOrEmpty)
//            if (!string.IsNullOrEmpty(input))
//            {
//                // if true do this
//                //Console.WriteLine("The string is empty");
//                Console.WriteLine($"The string contains: {input}");
//            }


//            if (input == "test")
//            {
//                Console.WriteLine("It equals test!");
//            }
//            else if (input.Contains("yacht"))
//            {
//                Console.WriteLine("It equals Yacht!");
//            }
//            else
//            {
//                Console.WriteLine("It doesn't contain anything!");
//            }

//            Car car = new Car();
//            car.AddSomeFuel(10f);


//            Car secondCar = new Car(20f, 150);

//            IncreaseFuel(car);

//            int result = Sum(10, 20);

//            Console.WriteLine("Program end!");
//            Console.ReadKey();
//        }

//        private static int Sum(int x, int y)
//        {
//            return x + y;
//        }

//        private static float Sum(float x, float y)
//        {
//            return x + y;
//        }

//        private static int Sum(int x, int y, int z)
//        {
//            return x + y + z;
//        }

//        public static void IncreaseFuel(Car car)
//        {
//            car.Fuel += 10;
//        }
//    }
//}

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
