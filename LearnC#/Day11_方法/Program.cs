namespace Day11_方法
{
    internal class Program
    {
        static bool IsQualified(int efficiency)
        {

            return efficiency >= 80;// 效率 >= 80 返回 true // 否则返回 false
        }

        static int GetMax(int[] efficiencies)
        {
            int max = efficiencies[0];

            foreach (int efficiency in efficiencies)
            {
                if (efficiency > max)
                {
                    max = efficiency;
                }
            }

            return max;
        }

        static double GetAverage(int[] efficiencies)
        {
            int sum = 0;
            foreach (int efficiency in efficiencies)
            {
                sum += efficiency;
            }
            return (double)sum / efficiencies.Length;
        }

        static int GetQualifiedCount(int[] efficiencies)
        {
            int count = 0;
            foreach (var efficiency in efficiencies)
            {
                if (efficiency >= 80)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] efficiencies = { 80, 65, 92, 45, 88, 70 };
            foreach (int efficiency in efficiencies)
            {
                bool Qualified = IsQualified(efficiency);  /*  efficiencies = 整个数组   efficiency = foreach 当前取出来的一个数字。*/

                if (Qualified)
                {
                    Console.WriteLine($"设备效率：{efficiency} → 达标！");
                }
                else
                {
                    Console.WriteLine($"设备效率：{efficiency} → 不达标！");
                }

            }
            Console.WriteLine("--------------------");
            Console.WriteLine($"最高效率：{GetMax(efficiencies)}");
            Console.WriteLine($"平均效率：{GetAverage(efficiencies):F1}");
            Console.WriteLine($"达标设备数量：{GetQualifiedCount(efficiencies)}");
        }
    }
}
