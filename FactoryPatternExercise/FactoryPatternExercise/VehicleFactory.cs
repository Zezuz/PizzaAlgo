using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
     public static class VehicleFactory
    {
        
        
        public static IVehicle GetVehicle(int numberOfTires) 
        {
           
            
            if (numberOfTires > 4)
            {
                return new Truck();
            }
            else if (numberOfTires == 4)
            {
                return new Car();
            }
            else 
            {
                return new Motorcycle();
            };
        }





    }
}
