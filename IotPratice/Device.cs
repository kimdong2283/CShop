using System;
using System.Collections.Generic;
using System.Text;

namespace IotPratice
{
    public class Device
    {
        private string _deviceId;

        public string DeviceId 
        {  
            get { return _deviceId; } 
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                _deviceId = value;
            }
        }
        public string Location { get; set; }

        public bool IsOnline { get; set; }

        public Device()
        {

        }
        public Device(string deviceId, string location)
            {
                DeviceId = deviceId;
                Location = location;
                IsOnline = true; 
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {DeviceId}, Location: {Location}, Online: {IsOnline}");
        }
    }
}
