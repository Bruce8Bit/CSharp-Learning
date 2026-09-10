namespace Day2_变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int age;   // 创建变量，创建了一个数据的容器，容器的名字age，容器的类型int

            age = 18;   // 赋值

            double age2;

            char age3;

            double height;

            char sex;*/


            int a = 3, b = 8;
            Console.WriteLine(a + b); // 11
            Console.WriteLine("a + b");// a + b
            Console.WriteLine(a + "+" + b); // 3+8
            Console.WriteLine("a+b" + a + b); // a + B38
            Console.WriteLine("a+b" + (a + b)); // a + b11
        }
    }
}