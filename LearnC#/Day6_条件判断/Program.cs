namespace Day6_条件判断
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            基本结构：
            if (条件)
            {
                // 条件成立时执行
            }
            */

            /*
            Console.WriteLine("请输入你的年龄：");
            string Input = Console.ReadLine();
            int age = int.Parse(Input);

            if (age >= 18)
            {
                Console.WriteLine("你可以进入！");
            }
            else
            {
                Console.WriteLine("未成年禁止入内！！！！！！！！");
            }
            */

            Console.Write("请输入成绩：");
            string input = Console.ReadLine();
            int score = int.Parse(input);
            
            if (score < 0 || score > 100) 
            {
                Console.WriteLine("请输入0~100!!!!!!!");
            }
            
            else if (score >= 90)
            {
                Console.WriteLine("优秀！");
            }
            
            else if(score >= 80)
            {
                Console.WriteLine("良好！");
            }
            
            else if (score >= 60)
            {
                Console.WriteLine("及格！");
            }
            
            else
            {
                Console.WriteLine("不及格");
            }
            
        }
    }
}
