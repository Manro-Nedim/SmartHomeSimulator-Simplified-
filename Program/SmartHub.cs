using System;
using System.Collections.Generic;

namespace Program
{
    class SmartHub : Device
    {
        public SmartHub(string name) : base(name) { name = null; }
        List<Device> devices = new List<Device>();
        public void AddDevice(Device device)
        {
            devices.Add(device);
        }

        public void ShowStatus()
        {
            Console.WriteLine("--- SMART HOME SYSTEM STATUS ---");

            foreach (var device in devices)
            {
                string status = device.IsOn ? "On" : "Off";
                Console.WriteLine($"Type: {device.Type} | Location: {device.Name} | Status: {status}");
            }
        }
        public void TurnAllOff()
        {
            foreach (var device in devices) 
            {
                if (IsOn)
                    TurnOff();
            }
        }
    }
}
