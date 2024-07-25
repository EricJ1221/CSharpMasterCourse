using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    // An Interface is a contract
    // Classes implement interfaces
    // Interfaces must be full implemented
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();   

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController battery = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery); // BatteryPoweredGameController inherits the interfaces from the GameController Class
            controllers.Add(batteryKeyboard);

            foreach(IComputerController controller in controllers) 
            {
                if (controller is GameController gc) // You can use two different variables to talk to the same class
                {

                }
                if (controller is IBatteryPowered powered)
                {
                    
                }
            }
            //using (GameController gc = new GameController()) // This allows us to close out the method whether we crash or just shutdown
            //{ // This is useful for memory management
            
            //}
            
           

            Console.ReadLine();
        }
    }

    public interface IComputerController : IDisposable // The convention is to start and Interface with a Capital "I", then Pascal case
    {// Interfaces contain definitions, You can also combine contracts, IComputerController : IDisposable
        void Connect();
        void Disconnect();
        void CurrentKeyPressed();
    }

    public class Keyboard : IComputerController
    {
        public void Connect() // <-- Signature line of a method, Defines the return type, the name, and any parameters it may have
        {

        }
        public void Disconnect() 
        { 
        
        }
        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public interface IBatteryPowered
    {
        int BatteryLevel { get; set; }
    }

    public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }

    public class GameController : IComputerController, IDisposable // You can inherit from a class and impelement one or more interfaces, The base class would come first
    { // IDisposable is build into the .net framework
        public void Connect()
        {

        }
        public void Disconnect()
        {

        }
        public void CurrentKeyPressed()
        {

        }
        public void Dispose()
        {
            //do whatever shutdown tasks are needed
        } 
    }
    public class BatteryPoweredGameController : GameController, IBatteryPowered // The child class inherits the interfaces of the parent class
    {
        public int BatteryLevel { get; set; }
    }
}
