using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Book book = new Book();


            // InventoryItem item = new InventoryItem(); // Can instantiate because its a class, an abstract class that is.

            // item.ProductName = "Test";

            // abstract classes cannot be directly instantiated but they can be inherited.
            // You can put methods in your abstract class that you can then use in your inherited class
            // However don't use them as a dumping ground for all methods. Follow the "Is a" rule.

            // Practice: Create an abstract class that has an interface applied to it.
            // When instantiating the child class store it using the interface type.

            IPremiumVehicle premiumVehicle = new Car
            {
                TrimPackage = "Luxury",
                BlueToothCapability = "Yes"
            };

            Console.WriteLine($"Trim Package: {premiumVehicle.TrimPackage}");
            Console.WriteLine($"Bluetooth Capability: {premiumVehicle.BlueToothCapability}");

        }
    }

    //public class InventoryItem
    //{
    //    public string ProductName { get; set; }
    //    public int QuantityOnHand { get; set; } 

    //}

    //public class Book : InventoryItem
    //{

    //}
    public interface IPremiumVehicle
    {
        string TrimPackage { get; set; }
        string BlueToothCapability { get; set; }
    }

    public class Vehicle // abstract class
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle, IPremiumVehicle // Inheritance 101, the inherited class comes before the interfaces
    {
        public int NumberOfWheels { get; set; } = 4;

        // Implementing IPremiumVehicle properties
        public string TrimPackage { get; set; }
        public string BlueToothCapability { get; set; }
    }
}
