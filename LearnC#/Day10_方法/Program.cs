namespace Day10_方法
{
    internal class Program
    {
        /*
         static void ShowWelcome(string name)
        {
            Console.WriteLine($"欢迎 {name} 使用MES管理系统");
        }

        static void Main(string[] args)
        {
            ShowWelcome("Alice");
        }
         */

        /*
          static void ShowEmployee(string name, string number)
         {
             Console.WriteLine($"员工姓名：{name}");
             Console.WriteLine($"员工编号：{number}");
         }
         static void Main(string[] args) 
         {
             ShowEmployee("Alice","E001");
         }

         */


        /*
         //方法开始"返回结果"
        static int Add(int a, int b)
        {
            return a + b; 
        }
        static void Main(string[] args)
        {
            int result = Add(20, 30);

            Console.WriteLine($"结果：{result}");
        }
         */


        /*
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
          static void Main(string[] args)
          {
              int[] efficiencies = { 80, 65, 92, 45, 88, 70 };

              int result = GetMax(efficiencies);
              Console.WriteLine($"最高效率：{result}");
          }
         */


        /*
         static double GetAverage(int[] efficiencies)
        {
            int sum = 0;
            foreach (int efficiency in efficiencies)
            {
                sum += efficiency;
            }
            return (double)sum / efficiencies.Length;
        }

        static void Main(string[] args)
        {
            int[] efficiencies = { 80, 65, 92, 45, 88, 70 };

            double average = GetAverage(efficiencies);
            Console.WriteLine($"平均效率：{average:F1}");
        }
         */

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
            int maxEfficiency = GetMax(efficiencies);
            double avgEfficiencyPercent = GetAverage(efficiencies);
            int qualifiedDeviceCount = GetQualifiedCount(efficiencies);
            Console.WriteLine($"最高效率：{maxEfficiency}");
            Console.WriteLine($"平均效率：{avgEfficiencyPercent:F1}");
            Console.WriteLine($"达标设备数量：{qualifiedDeviceCount}");
        }
    }
}
