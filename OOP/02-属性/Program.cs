namespace _02_属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device();
            device.Name = "weldingEquipment";
            Console.WriteLine(device.Name);
        }
    }
}
