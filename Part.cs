using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskAppC968
{
    public abstract class Part
    {
        int PartID { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int InStock { get; set; }
        int Min { get; set; }
        int Max { get; set; }
    }
}
