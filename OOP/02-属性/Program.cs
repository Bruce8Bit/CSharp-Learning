namespace _02_属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device("CR277");
            Console.WriteLine("设备编号："+ device.Number);
            
            device.Name = "weldingEquipment";
            Console.WriteLine("设备名称:" + device.Name);

            device.Temperature = 80;
            Console.WriteLine($"设备温度：{device.Temperature}");
        }
    }
}
