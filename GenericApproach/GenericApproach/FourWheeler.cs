using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    // Class FourWheeler inheriting from Vehicle and implementing IExteriorDesign
    internal class FourWheeler<T> : Vehicle<T>,IExteriorDesign<T>
    {
        //  Method to get exterior design of Car
        public string InteriorDesign<T>(T data) where T : Vehicle<T>
        {
            return "BMW car interior design ";
        }
        // Properties of Car class 
        public string interiorDesign { get; set; }
        public int NumberofDoor {  get; set; }
        // Method to get the details of Car
        public override void RearBreak()
        {
            Console.WriteLine("Car rear break");
        }
        public override void FrontBreak()
        {
            Console.WriteLine("Car front break");
        }
    }
}
