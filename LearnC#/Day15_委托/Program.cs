namespace Day15_委托
{
    internal class Program
    {
        // 定义一个委托
        // 这个委托只能保存：
        // 1. 没有参数的方法
        // 2. 没有返回值的方法
        delegate void DeviceAction();

        // 一个符合要求的方法
        static void StartDevice()
        {
            Console.WriteLine("设备启动");
        }

        static void Main(string[] args)
        {
            // 创建一个 DeviceAction 类型的变量
            // 并把 StartDevice 方法交给它
            DeviceAction action = StartDevice;

            // 通过委托变量调用 StartDevice
            action();
        }
    }
}