using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public interface IVehicle
    {
        public int NumberOfTires { get; set; }
        public void Drive();

    }
}
