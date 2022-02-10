using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        //default constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        //simple constructor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}