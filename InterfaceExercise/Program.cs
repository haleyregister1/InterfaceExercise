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
            //Creatively display and organize their values

            Car myCar = new Car();
            {
                myCar.HasFourWheels = true;
                myCar.HasFourDoors = true;
                myCar.HasHeadLights = true;
                myCar.HasRearCamera = true;

                myCar.Make = "Cadillac";
                myCar.Model = "SRX";

                myCar.TrunkSpace = 30;
                myCar.GasMileage = 21;
            }
            Truck myTruck = new Truck();
            {
                myTruck.HasFourWheels = true;
                myTruck.HasFourDoors = true;
                myTruck.HasHeadLights = true;
                myTruck.HasRearCamera = true;

                myTruck.Make = "Ford";
                myTruck.Model = "F150";

                myTruck.BedSize = 96;
                myTruck.GasType = "diesel";
            }
            SUV mySUV = new SUV();
            {
                mySUV.HasFourWheels = true;
                mySUV.HasFourDoors = true;
                mySUV.HasHeadLights = true;
                mySUV.HasRearCamera = true;

                mySUV.Make = "GMC";
                mySUV.Model = "Yukon";

                mySUV.CargoHoldSize = 95;
                mySUV.AmountOfSeats = 7;
            }

            Console.WriteLine($"does my car have: four wheels? {myCar.HasFourDoors}. Four doors? {myCar.HasFourDoors}." +
                $"Headlights? {myCar.HasHeadLights}. What about a backup camera? {myCar.HasRearCamera}. It is a {myCar.Make} " +
                $"{myCar.Model}, and it has about {myCar.TrunkSpace}ft trunk space, and {myCar.GasMileage}mi/g of gas mileage.");
            Console.WriteLine("");

            Console.WriteLine($"does my truck have: four wheels? {myTruck.HasFourDoors}. Four doors? {myTruck.HasFourDoors}." +
                $"Headlights? {myTruck.HasHeadLights}. What about a backup camera? {myTruck.HasRearCamera}. It is a {myTruck.Make} " +
                $"{myTruck.Model}, and it has about {myTruck.BedSize} of bed space, and takes {myTruck.GasType} gas.");
            Console.WriteLine("");

            Console.WriteLine($"does my SUV have: four wheels? {mySUV.HasFourDoors}. Four doors? {mySUV.HasFourDoors}." +
                $"Headlights? {mySUV.HasHeadLights}. What about a backup camera? {mySUV.HasRearCamera}. It is a {mySUV.Make} " +
                $"{mySUV.Model}, and it has about {mySUV.CargoHoldSize} cargo space, and {mySUV.AmountOfSeats} seats.");
        }
    }
}
