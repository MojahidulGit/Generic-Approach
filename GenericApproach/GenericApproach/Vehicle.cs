using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    // Generic class Vehicle 
    internal class Vehicle<T>
    {
        //Properties
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int NumberofGear { get; set; }
        public int EngineCapcityCC { get; set; }
        public int NumberofSeat { get; set; }
        public VehicleType Type { get; set; }

        //Methods //Virtual methods //Polymorphism //Method overriding 
        public virtual void RearBreak()
        {
            Console.WriteLine("Rear break");
        }
        public virtual void FrontBreak()
        {
            Console.WriteLine("Front break");
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
    }
}
