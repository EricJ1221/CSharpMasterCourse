using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesPractice
{
    internal class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress
        {
            get 
            { 
                return $"{StreetAddress}. {City}, {State} {ZipCode}"; 
            }
            
        }



    }
}
