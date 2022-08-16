namespace Abstraction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.start();
            car.acc();
            car.musicStart();
            car.musicEnd();
            car.brake();
            car.brakeRelease();
            car.stop();
            
        }
    }
}