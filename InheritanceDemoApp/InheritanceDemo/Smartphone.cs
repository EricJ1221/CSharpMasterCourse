using System.Collections.Generic;

// Inheritance helps to relieve us of using redundant code
namespace InheritanceDemo
{
    public class Smartphone : Phone
    {
        public List<string> Apps { get; set; }
        public void ConnectToInternet()
        {

        }
    }
}
