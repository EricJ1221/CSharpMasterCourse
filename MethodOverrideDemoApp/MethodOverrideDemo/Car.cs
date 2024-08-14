using System;


namespace MethodOverrideDemo
{
    public abstract class Car
    {
        public int NumberOfWheels { get; set; } 

        public virtual void StartCar(Car car)
        {
            Console.WriteLine($"Turn key and start {car}");
        }
        public void StopCar(Car car) 
        {
            Console.WriteLine($"Turn key and stop {car}");
        }

        public abstract void SetClock(); // This could also be implemented in an interface, it depends on where you want it and how accessible you want the method.
    }
}
