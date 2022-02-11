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
        public List<IDestroyable> DestroyablesNearby;

        //simple constructor
        public Car(float speed, string color)
        //public Car(float speed, string color):base(speed, color)
        {
            this.Speed = speed;
            this.Color = color;
            //initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            //initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

        //implementing the interface's method
        public void Destroy()
        {
            //when a car gets destroyed we should play the destruction sound
            //and fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            //go through each destroyable object nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}