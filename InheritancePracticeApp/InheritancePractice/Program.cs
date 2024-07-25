using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.NumberOfBreaks = 4;
            car.NumberOfGears = 5;
            car.Brand = "Audi";
            car.NumberOfPedals = 3;
            car.NumberOfDoors = 2;
            car.NumberOfRearViewMirrors = 3;
            car.TurnOn();
            car.TurnOff();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.NumberOfWheels = 2;
            motorcycle.NumberOfBreaks = 2;
            motorcycle.NumberOfGears = 6;
            motorcycle.Brand = "Indian Scout";
            motorcycle.NumberOfRearViewMirrors = 2; ;
            motorcycle.TurnOn();
            motorcycle.TurnOff();

            Boat boat = new Boat();
            boat.Throttle = 1;
            boat.NumberOfRearViewMirrors = 1;
            boat.NumberOfMotors = 2;
            boat.NumberOfGears = 1;
            boat.TurnOn();
            boat.TurnOff();

            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        public void TurnOn()
        {

        }
        public void TurnOff() 
        { 
        
        }
        public int NumberOfGears { get; set; }
        public int NumberOfRearViewMirrors { get; set; }

    }
    public class Car : Vehicle  
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public string Brand { get; set; }
        public int NumberOfPedals { get; set; }
        public int NumberOfBreaks { get; set; }
        

    }
    public class Boat : Vehicle
    {
        public int NumberOfMotors { get; set; }
        public int Throttle { get; set; }
    }
    public class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public int Throttle { get; set; }
        public int Breaks { get; set; }
        public string Brand { get; set; }
        public int NumberOfBreaks { get; set; }
    }
}
