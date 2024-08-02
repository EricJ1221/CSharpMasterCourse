using InheritanceHomeoworkPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


// We are creating an inventory system

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args, AudioBookModel audioBookModel)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };
            var boat = new BoatModel { ProductName = "Bass boat", Manufacturer = "Champion" };
            var audiobook = new AudioBook { ProductName = "The way of Kings", Author = "Brandon Sanderson", PlaybackDuration = 2400 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.Write("Do you want to rent or purchase something: (rent, purchase)");
            string rentalDecision = Console.ReadLine();
            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write($"Item: {item.QuantityInStock}");
                    Console.Write("Do you want to rent this item (yes/no)");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }
                    Console.Write("Do you want to return this item (yes/no)");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else if (rentalDecision.ToLower() == "purchase")
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this product (yes/no): ");
                    string wantToPurchase = Console.ReadLine();
                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase(audioBookModel);
                    }
                }
            }
            Console.WriteLine("We are done.");

            Console.ReadLine();
        }
    }

}

