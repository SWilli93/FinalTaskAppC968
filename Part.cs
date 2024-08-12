using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskAppC968
{
    abstract class Part
    {
        int PartID { get; }
        string Name { get;}
        decimal Price { get;}
        int InStock { get; }
        int Min { get; }
        int Max { get; }
    }
}
