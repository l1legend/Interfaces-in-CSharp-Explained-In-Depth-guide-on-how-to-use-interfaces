﻿using System;

namespace InheritanceDemo2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chairs to the IDestroyable list of the car
            //so that when we destory the car the destroyable objects
            //that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destroy the car
            damagedCar.Destroy();
        }
    }
}