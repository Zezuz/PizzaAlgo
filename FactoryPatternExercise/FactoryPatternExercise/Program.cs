using System;
using System.Collections.Generic;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many tires do you want on your new car?" );
            Console.WriteLine($"Type 1 for: Car\n" +
                              $"Type 2 for: Motorcycle\n" +
                              $"Type 3 or higher for: Truck\n");
            var userInput = int.Parse(Console.ReadLine());

            List<IVehicle> vehicles = new List<IVehicle>();

            if (userInput == 1) 
            {
                vehicles.Add(VehicleFactory.GetVehicle(4));
            }
            else if (userInput == 2) 
            {
                vehicles.Add(VehicleFactory.GetVehicle(2));
            }
            else 
            {
                vehicles.Add(VehicleFactory.GetVehicle(6));
            }

            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].Drive();
            }

            //foreach (var vehicle in vehicles)
            //{
            //    vehicle.Drive();
            //}
        }

       


    }


}
