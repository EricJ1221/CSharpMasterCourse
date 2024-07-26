using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfacePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runners = new List<IRun>()
            {
                new Person {Name = "John"},
                new Person {Name = "Eric"},
                new Animal {Species = "Cheetah"},
                new Animal {Species = "Elephant"}
            };

            foreach (var runner in runners) 
            { 
                runner.Run();
            }
        }
    }

    public interface IRun
    {
        void Run();
    }

    public class Person : IRun
    {
        public string Name { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} is running.");
        }
    }
    public class Animal : IRun
    {
        public string Species { get; set; }
        public void Run()
        {
            Console.WriteLine($"The {Species} is running.");
        }
    }
}
