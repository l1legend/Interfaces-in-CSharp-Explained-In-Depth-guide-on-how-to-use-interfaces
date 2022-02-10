using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Car : Vehicle, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }

        //creating a new property to store the destroyable objects nearby
        //when a car gets destroyed it should destory the nearby object
        //this list is of type IDestroyable which means it can store any object
        //that implements this interface and we can only access the properties and
        //methods in this interface

        //simple constructor
        public Car(float speed, string color)
        //public Car(float speed, string color):base(speed, color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}