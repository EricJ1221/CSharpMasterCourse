using System;

// We are creating an inventory system

namespace InheritanceMiniProject
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging.");
        }

        public void Rent()
        {
            QuantityInStock -= 1; // You would check to see if the quantity is zero for a realistic application
            Console.WriteLine("This excavator has been rented.");
        }

        public void ReturnRental()
        {
            throw new NotImplementedException();
        }
    }
}
