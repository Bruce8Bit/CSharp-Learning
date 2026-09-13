using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day7_循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //基本结构
            switch (变量)
            {
                case 值1:
                    // 执行代码
                    break;

                case 值2:
                    // 执行代码
                    break;

                default:
                    // 都不符合
                    break;

            */

            /*
            
            Console.WriteLine("请输入一个数字:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            
             
            switch (number)
            {
                case 1:
                    Console.WriteLine("苹果");
                    break;
                
                case 2:
                    Console.WriteLine("香蕉");
                    break;
                
                case 3:
                    Console.WriteLine("橙子");
                    break;
                
                default:
                    Console.WriteLine("没有这个水果!");
                    break;
            }

             */



            /*
            
            //MES菜单程序

            Console.WriteLine("====== MES系统 ======");
            Console.WriteLine("1. 查询产品");
            Console.WriteLine("2. 查询设备");
            Console.WriteLine("3. 查询订单");
            Console.WriteLine("4. 退出系统");
            Console.WriteLine("=====================");

            Console.Write("请选择：");

            string input = Console.ReadLine();
            int choice = int.Parse(input);

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
                    Console.WriteLine("系统退出...");
                    break;

                default:
                    Console.WriteLine("输入错误");
                    break;
            }
             
             */

            /*
             
            // 设备状态查询 
             Console.Write("请输入设备状态：");

            string input = Console.ReadLine();
            int status = int.Parse(input);

            switch (status)
            {
                case 1:

                    Console.WriteLine("设备运行中");
                    Console.WriteLine("允许生产!");        
                    break;

                case 2:
                    
                    Console.WriteLine("设备停机");
                    Console.WriteLine("禁止生产");
                    
                    break;

                case 3:

                    Console.WriteLine("设备故障");
                    Console.WriteLine("禁止生产");

                    break;

                case 4:

                    Console.WriteLine("设备维护中");
                    Console.WriteLine("当前进行设备维护");

                    break;

                default:
                    Console.WriteLine("状态错误");
                    break;
            }

             */


            // MES管理系统

            Console.WriteLine("====== MES管理系统 ======");
            Console.WriteLine("1. 产品查询");
            Console.WriteLine("2. 设备状态");
            Console.WriteLine("3. 订单查询");
            Console.WriteLine("4. 退出系统");
            Console.WriteLine("========================");

            Console.Write("请选择：");

            string input = Console.ReadLine();
            int choice = int.Parse(input);

            switch (choice)
            {
                case 1:
                    
                    Console.Write("请输入产品编号:");
                    string Pronumber = Console.ReadLine();
                    Console.WriteLine($"正在查询产品:{Pronumber}");
                    break;

                case 2:
                    
                    Console.Write("请输入设备状态:");
                    string input2 = Console.ReadLine();
                    int status = int.Parse(input2);

                    switch (status)
                    {
                        case 1:
                            Console.WriteLine("运行中");
                            break;
                        case 2:
                            Console.WriteLine("停机");
                            break;
                        case 3:
                            Console.WriteLine("故障中");
                            break;
                        case 4:
                            Console.WriteLine("维护中");
                            break;
                        default:
                            {
                                Console.WriteLine("状态错误!!!");
                            }
                            break;
                    }
                    
                    break;

                case 3:
                    
                    Console.Write("请输入订单编号:");
                    string input3 = Console.ReadLine();
                    Console.WriteLine($"正在查询订单:{input3}");
                    
                    break;

                case 4:
                    
                    Console.WriteLine("系统退出!");
                    
                    break;

                default:
                    
                    Console.WriteLine("输入错误,请重新选择!!!");
                    
                    break;
            }

        }
    }
}
