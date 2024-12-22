using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    // Generic interface IInteriorDesign
    internal interface IInteriorDesign<T>
    {
        // Method to get interior design of MotorCycle
        string ExteriorDesign(T data);
    }
}
