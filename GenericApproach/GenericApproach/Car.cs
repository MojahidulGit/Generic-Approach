using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    // Generic class Car inheriting FourWheeler
    sealed class Car<T> : FourWheeler<T>
    {
        // Properties of Car class 
        Car() { }
        // Constructor of Car class
        public Car(string modelNo,int yearmake, int engineCapacityCC,int numberofGear,int numberofSeat,int numberofDoor,string interiordesign,VehicleType type):this()
        {
            // Initializing the properties
            ModelNo = modelNo;
            YearMake = yearmake;
            EngineCapcityCC = engineCapacityCC;
            NumberofGear = numberofGear;
            NumberofDoor = numberofDoor;
            NumberofGear = numberofGear;
            interiorDesign = interiordesign;
            Type = type;
        }
        // Method to start the engine of Car
        public override void StartEngine()
        {
            Console.WriteLine("Engine started with keyless ignition");
        }
        // Method to get the model of Car 
        public string GetCarModel()
        {
            return $"Car Model No : {ModelNo}";
        }
        // Method to get the model of Car with year as parameter 
        public string GetCarModel(int year)
        {
            return $"Car Model No : {ModelNo} year : {year}";
        }
    }
}
