using IotPratice;

class Program
{
    static void Main(string[] args)
    {
        DeviceManager deviceManager = new DeviceManager();

       
        
        while (true)
        {
            Console.WriteLine("1. 장비 등록");
            Console.WriteLine("2. 장비 목록");
            Console.WriteLine("3. 센서값 입력");
            Console.WriteLine("4. 센서 로그 보기");
            Console.WriteLine("0. 종료");

            string input = Console.ReadLine();
            string deviceId;
            string location;

            double temperature;
            int smoke;
            switch (input)
            {
                case "1":
                    while (true)
                    {
                        Console.Write("장비 ID: ");
                        deviceId = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(deviceId))
                        {
                            Console.WriteLine("장비 ID는 공백일 수 없습니다. 다시 입력해주세요.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.Write("설치 위치: ");
                        location = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(location))
                        {
                            Console.WriteLine("설치 위치는 공백일 수 없습니다. 다시 입력해주세요.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    deviceManager.AddDevice(new Device(deviceId, location));
                    break;

                    case "2":
                    deviceManager.PrintDevices();
                    break;

                    case "3":
                    while (true)
                    {
                        Console.Write("장비 ID: ");
                        deviceId = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(deviceId))
                        {
                            Console.WriteLine("장비 ID는 공백일 수 없습니다. 다시 입력해주세요.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.Write("온도: ");
                        if(double.TryParse(Console.ReadLine(), out temperature))
                        { 
                            break;
                        }
                        else
                        {
                            Console.WriteLine("온도는 숫자여야 합니다. 다시 입력해주세요.");
                            continue;
                        }
                    }

                    while(true)
                    {
                         Console.Write("연기: ");
                        if(int.TryParse(Console.ReadLine(), out smoke))
                        { 
                            break;
                        }
                        else
                        {
                            Console.WriteLine("연기는 숫자여야 합니다. 다시 입력해주세요.");
                            continue;
                        }
                    }

                    deviceManager.AddSensorLog(new SensorLog(deviceId, temperature, smoke));
                    break;

                    case "4":
                    deviceManager.PrintSensorLogs();
                    break;
            }
        }
    
    
    
    }
}