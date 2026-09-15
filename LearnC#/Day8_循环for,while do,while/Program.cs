namespace Day8_循环for_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            //for循环结构

            for (开始; 条件; 变化)
            {
                重复执行的代码
            }
             
             */

            /*
             int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum=sum+i; // 简写:sum += i
            }

            Console.WriteLine($"1~100的总和：{sum}");
             */


            /*
             for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
             */


            /*
            
            while循环结构:

             while (条件)
             {
                 // 重复执行
             }

             */

            /*
             int i = 1;       // ① 初始值

             while (i <= 5)   // ② 条件：满足就继续循环
             {
                 Console.WriteLine(i); // ③ 输出
                 i++;                  // ④ 每次循环让 i + 1  
             }
            */


            /*
             int number = -1;

            while (number != 0)// ! = 不等于
            {
                Console.Write("请输入数字：");

                string input = Console.ReadLine();
                number = int.Parse(input);

                Console.WriteLine($"你输入了：{number}");
            }
            Console.WriteLine("程序结束！");
             */


            /*
do while 结构:

            do
            {
                // 执行
            }
            while (条件);
             
             */

            //while    → 先判断，再执行
            //do while → 先执行，再判断

            /*
             
            int choice = 0;

            do
            {
                Console.WriteLine("====== MES管理系统 ======");
                Console.WriteLine("1. 产品查询");
                Console.WriteLine("2. 设备状态");
                Console.WriteLine("3. 订单查询");
                Console.WriteLine("4. 退出系统");
                Console.WriteLine("========================");

                Console.Write("请选择：");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("正在查询产品...");
                        break;

                    case 2:
                        Console.WriteLine("正在查询设备...");
                        break;

                    case 3:
                        Console.WriteLine("正在查询订单...");
                        break;

                    case 4:
                        Console.WriteLine("系统退出！");
                        break;

                    default:
                        Console.WriteLine("输入错误，请重新选择！");
                        break;
                }

            } while (choice != 4);

            */

            /*
            int target = 7;

            while (true)
            {
                Console.Write("请输入你猜的数字：");

                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (number == target)
                {
                    Console.WriteLine("猜对了！");

                    break;
                }
                else
                {
                    Console.WriteLine("猜错了，请继续！");
                }
            }
            */

            Random random = new Random();

            int target = random.Next(1, 101);
            int count = 0;

            while (true)
            {
                Console.Write("请输入你猜的数字：");

                string input = Console.ReadLine();
                int number = int.Parse(input);

                count++;

                if (number > target)
                {
                    Console.WriteLine("猜大了！");
                }
                else if (number < target)
                {
                    Console.WriteLine("猜小了！");
                }
                else
                {
                    Console.WriteLine("恭喜你，猜对了！");
                    Console.WriteLine($"你一共猜了 {count} 次。");
                    break;
                }
            }
        }
    }
}
