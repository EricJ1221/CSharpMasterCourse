using InheritanceMiniProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeoworkPractice.Models
{
    internal class BoatModel : InventoryItemModel, IRentable, IPurchasable
    {
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public int NumberOfSales { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IInventoryItem.ProductName { get; set; }
        int IInventoryItem.QuantityInStock { get; set; }

        public void Purchase()
        {
            throw new NotImplementedException();
        }

        void IRentable.Rent()
        {
            throw new NotImplementedException();
        }

        void IRentable.ReturnRental()
        {
            throw new NotImplementedException();
        }
    }
}
