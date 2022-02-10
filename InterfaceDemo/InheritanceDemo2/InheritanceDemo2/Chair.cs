using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Chair : Furniture
    {
        //simple constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}