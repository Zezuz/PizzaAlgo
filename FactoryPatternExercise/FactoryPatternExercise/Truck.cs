using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Truck : IVehicle
    {
        public int NumberOfTires { get; set; }
        public void Drive() 
        {
            Console.WriteLine("Building a new Truck!");
        }
        
    }
}
