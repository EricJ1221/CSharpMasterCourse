using System;

namespace InheritanceMiniProject
{
    internal class ExcavatorModel : InventoryItemModel, IRentable
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