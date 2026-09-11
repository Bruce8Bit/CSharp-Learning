namespace Day4_更安全的类型转换 // TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("请输入一个整数：");
            string input = Console.ReadLine();
            bool success = int.TryParse(input,out int number);

            if (success)
            {
                Console.WriteLine("转换成功！");
                Console.WriteLine($"是个数字是{input}");
            }
            else
            {
                Console.WriteLine("转换失败！！！");
                Console.WriteLine("请输入正确数字！！！");
            }



            定式：

            bool success = int.TryParse(input, out int number);

            if (success)
            {
                // 转换成功
            }
            else
            {
                // 转换失败
            }
            */

            /*
            
           //隐式转换：
           int a = 100;
           double b = a;
           Console.WriteLine(b);
           
           //显示转换：
           double c = 99.99;
           int d = (int)c;
           Console.WriteLine(d);

            */



            Console.WriteLine("请输入商品价格：");
            string price = Console.ReadLine();
            double priceNumber = double.Parse(price);

            Console.WriteLine("请输入购买数量：");
            string number = Console.ReadLine();
            int numberInt = int.Parse(number);

            double total = priceNumber * numberInt;

            Console.WriteLine($"商品单价：{priceNumber}"); // $"普通文字 {变量}"
            Console.WriteLine($"购买数量：{numberInt}");
            Console.WriteLine($"总价格：{total}");
        }
    }
}
