using InTheHand.Bluetooth;
using System;

namespace ConsoleAppCore31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var devices = Bluetooth.ScanForDevicesAsync().Result;
            foreach (var device in devices)
            {
                Console.WriteLine($"Name: {device.Name} Id: {device.Id}");
            }
        }
    }
}
