using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    // Generic interface IExteriorDesign
    internal interface IExteriorDesign<T>
    {
        //  Method to get interior design of MotorCycle
        string InteriorDesign<T>(T data) where T : Vehicle<T>;
    }
}
