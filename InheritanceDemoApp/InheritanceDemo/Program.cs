using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inheritance helps to relieve us of using redundant code

// Inheritance may seem like a magic cure, but it is not. Use it sparingly and follow the "is a" rule.
namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Smartphone smartphone = new Smartphone(); // You cannot inherit from more than one parent
            // LandLine landLine = new LandLine();

            List<Phone> phones= new List<Phone>();

            phones.Add(new CellPhone());
            phones.Add(new Smartphone());
            
            foreach (var phone in phones)
            {
                if (phone is CellPhone cell) // If the phone is a Cellphone, create a new value "cell"
                {
                    cell.Carrier = "AtnT";
                }

                if (phone is Smartphone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }

    public class WalkieTalking
    {

    }
}
