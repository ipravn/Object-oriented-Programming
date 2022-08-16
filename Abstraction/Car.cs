using System;

namespace Abstraction
{
    public class Car : Engine, Brake , Media
    {
        public void start()
        {
            Console.WriteLine("Your car is start");
        }

        public void stop()
        {
            Console.WriteLine("Your car is stop");
        }

        public void acc()
        {
            Console.WriteLine("Your car is accelerate.");
        }

        public void brake()
        {
            Console.WriteLine("Your car is will stop due to break.");
        }

        public void brakeRelease()
        {
            Console.WriteLine("Your car is started moving ahead.");
        }

        public void musicStart()
        {
            Console.WriteLine("Your Music is On.");
        }

        public void musicEnd()
        {
            Console.WriteLine("Your Music is off.");
        }
    }
}