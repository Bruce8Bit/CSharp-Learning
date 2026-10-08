namespace _03_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device1 = new Device();

            device1.Number = "D001";
            device1.Name = "激光焊接机";
            device1.Temperature = 28; // 注意： double 不带引号
            device1.Efficiency = 92;

            //Console.WriteLine(device1.Number);
            //Console.WriteLine(device1.Name);
            //Console.WriteLine(device1.Temperature);
            //Console.WriteLine(device1.Efficiency);

            

            //if (device1.IsHighTemperature())
            //{
            //    Console.WriteLine("设备温度过高！");
            //}
            //else
            //{
            //    Console.WriteLine("设备温度正常！");
            //}

            
            //if (device1.IsQualified())
            //{
            //    Console.WriteLine("达标！");
            //}
            //else
            //{
            //    Console.WriteLine("不达标！");
            //}
            //Console.WriteLine("---------------------------------------------");
            
            Device device2 = new Device();
            device2.Number = "D002";
            device2.Name = "视觉检测机";
            device2.Temperature = 35;
            device2.Efficiency = 65;

            //Console.WriteLine(device2.Number);
            //Console.WriteLine(device2.Name);
            //Console.WriteLine(device2.Temperature);
            //Console.WriteLine(device2.Efficiency);

            //if (device2.IsHighTemperature())
            //{
            //    Console.WriteLine("设备温度过高！");
            //}
            //else
            //{
            //    Console.WriteLine("设备温度正常！");
            //}


            //if (device2.IsQualified())
            //{
            //    Console.WriteLine("达标！");
            //}
            //else
            //{
            //    Console.WriteLine("不达标！");
            //}

            Device[] devices = { device1, device2 };// 创建一个 Device 类型的数组，把 device1 和 device2 两个对象放进去。
            int qualifiedCount = 0;//创建一个计数器
            double totalEfficiency = 0;
            foreach (Device device in devices)
            {
                Console.WriteLine(device.Number);
                Console.WriteLine(device.Name);
                Console.WriteLine(device.Temperature);
                Console.WriteLine(device.Efficiency);
                
                if (device.IsHighTemperature())
                {
                    Console.WriteLine("设备温度过高！");
                }
                else
                {
                    Console.WriteLine("设备温度正常！");
                }
                if (device.IsQualified())
                {
                    Console.WriteLine("达标！");
                    qualifiedCount++;
                }
                else
                {
                    Console.WriteLine("不达标！");
                }

                totalEfficiency += device.Efficiency;
            }
            Console.WriteLine("达标设备数量：" + qualifiedCount);
            double averageEfficiency = totalEfficiency / devices.Length;
            Console.WriteLine("平均效率:" + averageEfficiency);

            double maxTemperature = devices[0].Temperature;
            Device maxDevice = devices[0];
            foreach (Device device in devices)
            {
                if (device.Temperature > maxTemperature)
                {
                    maxTemperature = device.Temperature;
                    maxDevice = device;
                }
            }
            
            Console.WriteLine("最高温度：" + maxTemperature);
            Console.WriteLine("最高温度设备的编号：" + maxDevice.Number);
            Console.WriteLine("最高温度设备的名称：" + maxDevice.Name);


            double maxEfficiency = devices[0].Efficiency;
            Device maxEfficiencyDevice = devices[0];
            foreach (Device device in devices)
            {
                if (device.Efficiency > maxEfficiency)
                {
                    maxEfficiency = device.Efficiency;
                    maxEfficiencyDevice = device;
                }
            }
            Console.WriteLine("最高效率：" + maxEfficiency);
            Console.WriteLine("最高效率设备的编号：" + maxEfficiencyDevice.Number);
            Console.WriteLine("最高效率设备的名称：" + maxEfficiencyDevice.Name);
        }
    }
}
