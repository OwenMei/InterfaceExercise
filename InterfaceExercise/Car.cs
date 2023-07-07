using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public bool CanEnterParkingGarage { get; set; }
        public int CarId { get; set; }
        public int NumWheels { get; set; }
        public int NumDoors { get; set; }
        public int NumSeats { get; set; }
        public int Weight { get; set; }
        public string Logo { get; set; }
        public int NetWorth { get; set; }
    }
}
