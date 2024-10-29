using InTheHand.Bluetooth;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private async void Start()
    {
        Debug.Log("Scanning...");
        var devices = await Bluetooth.ScanForDevicesAsync();
        foreach (var device in devices)
        {
            Debug.Log($"Name: {device.Name} Id: {device.Id}");
        }
    }
}
