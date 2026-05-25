using System;
using System.Collections.Generic;
using System.Text;

namespace IotPratice
{
    public class DeviceManager
    {
        private List<Device> devices = new List<Device>();
        private List<SensorLog> sensorLogs = new List<SensorLog>();

        public void AddDevice(Device device)
        {
            devices.Add(device);
        }

        public void PrintDevices()
        {
            foreach (Device device in devices)
            {
                device.PrintInfo();
            }
        }

        public void AddSensorLog(SensorLog log)
        {
            sensorLogs.Add(log);

            Console.WriteLine("등록 완료");

            if(log.IsDanger())
            {
                Console.WriteLine("위험 감지");
            }
        }

        public void PrintSensorLogs()
        {
            foreach(SensorLog sensorlog in  sensorLogs)
            {
                sensorlog.PrintLog();
            }
        }
    }
}
