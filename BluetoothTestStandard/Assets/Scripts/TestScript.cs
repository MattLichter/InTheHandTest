using InTheHand.Bluetooth;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Scanning...");
        var devices = Bluetooth.ScanForDevicesAsync().Result;
        foreach (var device in devices)
        {
            Debug.Log($"Name: {device.Name} Id: {device.Id}");
        }
    }
}
