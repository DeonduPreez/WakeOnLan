using System;
using System.Threading.Tasks;

namespace WakeOnLan
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var exit = false;

            do
            {
                Console.WriteLine("Please enter the mac address: ");
                string mac = Console.ReadLine();
                try
                {
                    await WOL.WakeOnLan(mac);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e);
                }

                Console.WriteLine("Press the escape key to exit, press any other key to try again");

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
            } while (!exit);
        }
    }
}