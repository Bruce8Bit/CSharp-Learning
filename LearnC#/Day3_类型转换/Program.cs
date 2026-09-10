namespace Day3_类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            char a = 'A'; // 一个字符
            string b = "ABC"; // 一个字符串

            string ageText = "20"; //20是字符串，并不是数字

            int age = ageText; // 会报错
             
            
            int age = int.Parse(ageText);// 需要将字符串，换成整数
            //"20"  →  20
            //string → int
            
             
             */

            /*
            string text = "100";
            int number = int.Parse(text);
            Console.WriteLine(number + 11); // 字符串100，转成数字 与 数字11 相加 
            */

            Console.WriteLine("请输入您的年龄：");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            Console.WriteLine($"明年您{age + 1}岁");

        }
    }
}