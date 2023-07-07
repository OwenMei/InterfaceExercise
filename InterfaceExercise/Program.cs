using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            SUV suv1 = new SUV() { TrunkSize = 20, DirtLevel = 1, NumDoors = 4, NumSeats = 7, NumWheels = 4, Weight = 2100, Logo = "Honda", NetWorth = 40000000 };
            Truck truck1 = new Truck() { BedSize = 15, TowOrNo = false, NumDoors = 4, NumSeats = 7, NumWheels = 4, Weight = 2100, Logo = "Honda", NetWorth = 40000000 };
            Car car1 = new Car() { CanEnterParkingGarage = true, CarId = 1123432, NumDoors = 4, NumSeats = 7, NumWheels = 4, Weight = 2100, Logo = "Honda", NetWorth = 40000000 };


            //Creatively display and organize their values

            Console.WriteLine($"the SUV has a trunk size of {suv1.TrunkSize}, it has accumulated {suv1.DirtLevel} cm of dirt, has {suv1.NumDoors} doors, {suv1.NumSeats} seats, {suv1.NumWheels} wheels, and is {suv1.Weight} pounds. it is from {suv1.Logo} which has a net worth of {suv1.NetWorth}");
            Console.WriteLine($"the truck has a bed size of {truck1.BedSize}, it is {truck1.TowOrNo} that it has the ability to tow other cars, has {truck1.NumDoors} doors, {truck1.NumSeats} seats, {truck1.NumWheels} wheels, and is {truck1.Weight} pounds. it is from {truck1.Logo} which has a net worth of {truck1.NetWorth}");
            Console.WriteLine($"it is {car1.CanEnterParkingGarage} that the car can enter the parking garage, its car id is {car1.CarId}. it has {car1.NumDoors} doors, {car1.NumSeats} seats, {car1.NumWheels} wheels, and is {car1.Weight} pounds. it is from {car1.Logo} which has a net worth of {car1.NetWorth}");

        }
    }
}
