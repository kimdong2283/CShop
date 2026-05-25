using System;
using System.Collections.Generic;
using System.Text;

namespace IotPratice
{
    public class SensorLog
    {
        public string DeviceId { get; set; }
        public double Temperature { get; set; }
        public int Smoke {  get; set; }
        public DateTime CreateAt { get; set; }

        public SensorLog(string deviceiId, double temperature, int smoke)
        {
            DeviceId = deviceiId;
            Temperature = temperature;
            Smoke = smoke;
            CreateAt = DateTime.Now;
        }

        public bool IsDanger()
        {
            return Temperature >= 70 || Smoke >= 300;
        }

        public void PrintLog()
        {
            string status = IsDanger() ? "Danger" : "Safe";
            Console.WriteLine($"[{CreateAt}] 장비:{DeviceId} / 온도:{Temperature} / 연기:{Smoke} / 상태:{status}");
        }


    }
}
