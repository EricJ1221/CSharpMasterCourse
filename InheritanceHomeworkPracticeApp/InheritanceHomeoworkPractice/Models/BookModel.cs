using System;

namespace InheritanceMiniProject
{
    internal class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }
        public string Title { get; set; }   
        public string Author { get; set; }

        public bool HardBack { get; set; }
        public bool SoftBack { get; set; }
        public int NumberOfSales { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased.");
        }
    }
    internal class AudioBook : BookModel, IPurchasable, IRentable
    {
        public int PlaybackDuration { get; set; }
        public int NumberOfSales { get ; set; }

        public void Purchase(InventoryItemModel inventoryItemModel)
        {
            NumberOfSales += 1;
            Console.WriteLine(value: $"{inventoryItemModel.ProductName} Audio book has been purchased.");
        }

        public void Rent(AudioBook audioBookModel)
        {
            NumberOfSales += 1;
            Console.WriteLine("This Audio book has been rented.");
        }

        public void Rent()
        {
            throw new NotImplementedException();
        }

        public void ReturnRental()
        {
            throw new NotImplementedException();
        }
    }
}