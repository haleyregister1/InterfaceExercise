using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasFourWheels { get; set; }
        public bool HasFourDoors { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasRearCamera { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }

        public int CargoHoldSize { get; set; }
        public int AmountOfSeats { get; set; }
    }
}
