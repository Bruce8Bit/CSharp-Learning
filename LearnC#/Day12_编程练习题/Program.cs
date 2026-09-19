namespace Day12_编程练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 int 类型的数组
            // 数组里面一共有 5 个温度数据
            int[] temperatures = { 25, 32, 28, 35, 30 };


            // foreach 用来“依次取出数组中的每一个元素”
            //
            // int temper：
            //     表示“当前取出来的这个元素”是 int 类型
            //
            // temper：
            //     是我们自己起的变量名
            //     它会依次得到 25、32、28、35、30
            //
            // temperatures：
            //     表示我们要遍历的整个数组
            //
            // 可以把它理解成：
            //
            // 第1次循环：temper = 25
            // 第2次循环：temper = 32
            // 第3次循环：temper = 28
            // 第4次循环：temper = 35
            // 第5次循环：temper = 30
            //
            // 数组中的所有元素都取完以后，foreach 自动结束。
            foreach (int temper in temperatures) //foreach (int xxx in yyy) 从 yyy 里面，一个一个拿东西出来，每次拿出来的东西叫 xxx
            {
                // 判断当前温度是否大于 30
                //
                // 注意：
                // 这里的 temper 不是整个数组，
                // 而是“当前正在检查的那个温度”
                if (temper > 30)
                {
                    // 当前温度超过 30，输出警告
                    Console.WriteLine($"设备温度：{temper} → 警告：温度过高！");
                }
                else
                {
                    // 当前温度没有超过 30，说明正常
                    Console.WriteLine($"设备温度：{temper} → 温度正常！");
                }
            }
        }
    }
}