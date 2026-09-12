using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day5_运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            算术运算符
            int a = 20 ; 
            int b = 6 ;
            
            Console.WriteLine($"加法：{a + b}");
            Console.WriteLine($"减法：{a - b}");
            Console.WriteLine($"乘法：{a * b}");
            Console.WriteLine($"整除：{a / b}");
            Console.WriteLine($"取余：{a % b}");
            */


            /*
            //比较运算符

            int a = 20;
            int b = 6;

            bool result1 = a > b;
            Console.WriteLine(result1);

            bool result2 = a < b;
            Console.WriteLine(result2);

            bool result3 = a >= b;
            Console.WriteLine(result3);

            bool result4 = a <= b;
            Console.WriteLine(result4);

            bool result5 = a == b;
            Console.WriteLine(result5);

            bool result6 = a != b;
            Console.WriteLine(result6);

            */

            /*
             // 逻辑运算符
             int age = 18 ;
             bool hasTicket = true;

             bool canEnter = age >= 18 && hasTicket;

             Console.WriteLine(canEnter);
            */

            double price = 80;
            int quantity = 3;
            bool hasMoney = true;

            double total = price * quantity;
            Console.WriteLine($"总价：{total}");
            
            bool reach = total >= 200;
            Console.WriteLine($"是否达到200元：{reach}");

            bool canBuy = total >= 200 && hasMoney;
            Console.WriteLine($"是否可以购买：{canBuy}");

        }
    }
}
