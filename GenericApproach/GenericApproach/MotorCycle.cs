using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    //MotorCycle class inheriting TwoWheeler class
    sealed class MotorCycle<T> : TwoWheeler<T>
    {
        //Properties
        MotorCycle() { }
        //Parameterized Constructor
        public MotorCycle(string modelNo,int yearMake,int numberofGear,int engineCapacityCC,string startingMethod,int maxPowerBPH,int maxTorqueNM,int mileageKMPL,string color, VehicleType type) :this()
        {
            //Initializing the properties
            ModelNo = modelNo;
            YearMake = yearMake;
            NumberofGear = numberofGear;
            EngineCapcityCC = engineCapacityCC;
            StartingMethod = startingMethod;
            MaxPowerBPH = maxPowerBPH;
            MaxTorqueNM = maxTorqueNM;
            MileageKMPL = mileageKMPL;
            Color = color;
            Type = type;
        }
        //Method to start the engine
        public override void StartEngine()
        {
            Console.WriteLine("Engine started with kick");
        }
        //Method to get the model of MotorCycle
        public string GetMotorCycleModel()
        {
            return $"MotorCycle Model No :{ModelNo}";
        }
    }
}
