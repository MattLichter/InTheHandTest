using InTheHand.Bluetooth;

namespace ConsoleAppCore80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var devices = Bluetooth.ScanForDevicesAsync().Result;
            Console.WriteLine($"Found {devices.Count} devices");
            foreach (var device in devices)
            {
                Console.WriteLine($"Name: {device.Name} Id: {device.Id}");
            }
        }
    }
}
