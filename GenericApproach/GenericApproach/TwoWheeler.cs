using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    //TwoWheeler class inheriting Vehicle class and implementing IInteriorDesign interface
    internal class TwoWheeler<T> : Vehicle<T>,IInteriorDesign<T>
    {
        //Method to get interior design of MotorCycle
        public string ExteriorDesign(T data)
        {
            return " Sporty MotorCycle exterior desigin";
        }
        //Properties of MotorCycle
        public string StartingMethod { get; set; }
        public int MaxPowerBPH { get; set; }
        public int MaxTorqueNM { get; set; }
        public int MileageKMPL { get; set; }
        public string Color { get; set; }
        //Method to get the details of MotorCycle
        public override void FrontBreak()
        {
            Console.WriteLine("MotorCycle Front break");
        }
        public override void RearBreak()
        {
            Console.WriteLine("MotorCycle rear break");
        }
    }
}
