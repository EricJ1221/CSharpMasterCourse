using System;


namespace MethodOverrideDemo
{
    public class Tesla : Car
    {
        public override void StartCar(Car car)
        {
            Console.WriteLine("Think about your destination.");
        }
        public override void SetClock()
        {
            Console.WriteLine("It sets itself.");
        }
    }
}
