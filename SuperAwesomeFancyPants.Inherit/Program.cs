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
        public string Model { get; set; }
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
        public static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();
            listOfCars.Add(new Volkswagen());
            listOfCars.Add(new Audi());

            foreach (Car car in listOfCars)
            {
                if (car.GetType() == typeof(Volkswagen))
                {

                }
                if (car is Volkswagen volkswagen)
                {
                    //Volkswagen volkswagen = (Volkswagen) car;
                }
            }

            Car car2 = new Car();
            car2.DriveAround();

            Volkswagen vCar = new Volkswagen();
            vCar.DriveAround();
            vCar.SitInTheMiddle();

            Car secondVCar = new Volkswagen();
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
