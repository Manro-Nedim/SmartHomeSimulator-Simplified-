using Microsoft.SqlServer.Server;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotionSensor sensor = new MotionSensor();
            Thermostat thermostat = new Thermostat("Kitchen");
            Light light = new Light("Living Room");
            SmartHub hub = new SmartHub("");

            hub.AddDevice(light);
            hub.AddDevice(thermostat);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n=== SMART HOME CONTROL MENU ===");
                Console.WriteLine("1. Show status of all devices.");
                Console.WriteLine("2. Imitate movement (lights on).");
                Console.WriteLine("3. Change temperature in Thermostat.");
                Console.WriteLine("4. Turn off all devices.");
                Console.WriteLine("0. Exit.");
                Console.Write("\nSelect action: ");

                string input = Console.ReadLine();

                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        hub.ShowStatus();
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine($"[Simulation]: Someone's walking in {light.Name}...");
                        sensor.TriggerMotionSensor();
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        break;

                    case "3":
                        thermostat.SetTemperature();
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Turning all devices off...");
                        hub.TurnAllOff();
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.WriteLine("End of a simulation. Bye!");
                        return;

                    default:
                        Console.WriteLine("Error: Incorrect Input! Please, select action from 0 to 4.");
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
