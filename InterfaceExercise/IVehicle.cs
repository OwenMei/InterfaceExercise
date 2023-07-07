using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumWheels { get; set; }
        public int NumDoors { get; set; }
        public int NumSeats { get; set; }
        public int Weight { get; set;}

    }
}
