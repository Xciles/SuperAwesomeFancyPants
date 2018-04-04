using System;
using System.Collections.Generic;
using System.Text;

namespace SuperAwesomeFancyPants
{
    public class Car
    {
        //private const int _maxSpeed = 184;
        private int _maxSpeed = 184;
        //private static readonly int _maxSpeed = 184;

        public float Fuel { get; set; }

        //static CarT()
        //{
        //    _maxSpeed = 140;
        //}

        public Car()
        {
            Fuel = 40f;
        }

        public Car(float initialFuel, int maxSpeed)
        {
            Fuel = initialFuel;
            _maxSpeed = maxSpeed;
        }

        ~Car()
        {
        }

        public void AddSomeFuel(float fuelToAdd)
        {
            if (fuelToAdd <= 0)
            {
                throw new FuelNegativeException();
            }
            Fuel += fuelToAdd;
            _maxSpeed += 1;
            _maxSpeed = _maxSpeed + 1;
            _maxSpeed--;
        }

        public static void CallSomthingOnCar()
        {

        }
    }
}
