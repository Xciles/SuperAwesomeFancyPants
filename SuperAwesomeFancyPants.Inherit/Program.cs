using System;
using System.Collections.Generic;

namespace SuperAwesomeFancyPants.Inherit
{
    public class Car
    {
        // private 
        // protected
        // public
        public int NumberOfTires { get; set; }
        public int NumberOfDoors { get; set; }
        public float AmountOfFuel { get; set; }
        public string Model { get; protected set; }
        public string Description { get; set; }
        public string Country { get; set; }

        public Car()
        {
            Print();
        }

        protected void Print()
        {

        }

        public virtual void DriveAround()
        {
            Console.WriteLine("Driving around in my 'Car'!");
        }

    }

    public class Volkswagen : Car
    {
        public Volkswagen() { }
        public Volkswagen(int numberOfTires)
        {
            NumberOfTires = numberOfTires;
        }

        public override void DriveAround()
        {
            Console.WriteLine("Driving around in my Volkswagen!");
        }

        public void SitInTheMiddle()
        {
            Console.WriteLine("Sitting in the middle!");
        }
    }

    public class Audi : Car
    {
        public override void DriveAround()
        {
            Console.WriteLine("Driving around in my Audi!");
        }
    }


    public class Program
    {
        private static int ReturnInt()
        {
            return 1234;
        }

        public static void Main(string[] args)
        {
            var listOfCars = new List<Car>();
            listOfCars.Add(new Volkswagen(4));
            listOfCars.Add(new Audi());

            foreach (var car in listOfCars)
            {
                if (car.GetType() == typeof(Volkswagen))
                {

                }
                if (car is Volkswagen volkswagen)
                {
                    //Volkswagen volkswagen = (Volkswagen) car;
                }
            }

            int returnVariable = ReturnInt();
            var returnVariable2 = ReturnInt();

            var car2 = new Car();
            car2.DriveAround();

            var volkwagen = new Volkswagen()
            {
                NumberOfTires = 4
            };

            var vCar = new Volkswagen(4);
            vCar.DriveAround();
            vCar.SitInTheMiddle();

            var secondVCar = new Volkswagen(4);
            secondVCar.DriveAround();

            Audi audi = new Audi();
            audi.DriveAround();

            Car secondAuri = new Audi();
            secondAuri.DriveAround();


            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
