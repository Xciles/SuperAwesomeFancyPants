using System;
using System.Collections.Generic;
using System.Text;

namespace SuperAwesomeFancyPants
{
    public class Car
    {
        //private float _numberOfFuel;
        public float Fuel { get; private set; }
        public float Milage { get; private set; }

        public float Range { get { return Fuel * Milage;} }

        //private float _fuel;

        //public float Fuel
        //{
        //    get => _fuel;
        //    set => _fuel = value;
        //}

        /// <summary>
        /// THis creates a car using 50 fuel
        /// </summary>
        public Car()
        {
            Fuel = 50f;
        }

        /// <summary>
        /// This creates a car using given fuel
        /// </summary>
        /// <param name="fuel">The amount of fuel to craete the car with</param>
        public Car(float fuel)
        {
            Fuel = fuel;
        }

        public void AddAmmountOfFuel(float ammountOfFuel)
        {
            Fuel += ammountOfFuel;
            //_numberOfFuel = _numberOfFuel + ammountOfFuel;
        }
    }
}
