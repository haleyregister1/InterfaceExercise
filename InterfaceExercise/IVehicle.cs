using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasFourWheels { get; set; }
        public bool HasFourDoors { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasRearCamera { get; set; }
    }
}
