using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismus
{
    interface IMaterial 
    {
        double Density { get; set; }
        double Mass { get; }
    }
}
