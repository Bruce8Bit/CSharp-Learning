namespace Day9_数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int[] numbers =
            {
                10,
                20,
                30,
                40,
                50,
                60,
                70
            };
            for (int i = 0; i < numbers.Length; i++) // numbers.Length; 条件: 表示数组中有多少个元素。
            {
                Console.WriteLine(numbers[i]);
            }
             */

            /*
             int[] efficiencies =
            {
                80,
                60,
                90,
                45
            };
            foreach (int efficiency in efficiencies)
            {
                if (efficiency >= 80)
                {
                    Console.WriteLine(efficiency);
                }
            }
             */

            /*
              int[] temperatures = { 25, 30, 28, 35, 22 };

             foreach (int temperature in temperatures)
             {
                 if (temperature>30)
                 {
                     Console.WriteLine(temperature);cw
                 }
             }
             */

            /*
             int[] efficiencies = { 80, 65, 92, 45, 88, 70 };
            int count = 0;

            foreach (int efficiency in efficiencies)
            {
                if (efficiency >= 80)
                { 
                    count++;
                    
                }
            }
            Console.WriteLine($"达到80%以上的设备数量：{count}");
             */


            /*
             //求平均效率

            int[] efficiencies = { 80, 65, 92, 45, 88, 70 };
            int sum = 0;

            foreach (int efficiency in efficiencies)
            {
                sum += efficiency;
            }

            Console.WriteLine($"平均效率:{ sum / efficiencies.Length}");
            Console.WriteLine($"平均效率：{(double)sum / efficiencies.Length}");//到小数把其中一个转换成 double
            Console.WriteLine($"平均效率：{(double)sum / efficiencies.Length:F1}");//保留 1 位小数

             */

            int[] efficiencies = { 80, 65, 92, 45, 88, 70 };
            int min = efficiencies[0];
            foreach (int efficiency in efficiencies)
            {
                if (efficiency < min)
                {
                    min = efficiency;
                }
            }
            Console.WriteLine($"目前最高效率:{min}");
        }
    }
}
