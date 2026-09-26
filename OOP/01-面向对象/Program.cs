namespace _01_面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             // 步骤1：利用 Customer 类创建一个对象 c1（声明 + 实例化一步到位）
            // c1 就是一个具体的"顾客"，它有类中定义的所有属性和方法
            Customer c1 = new Customer();

            // 步骤2：先声明一个对象变量 c2
            // 此时 c2 还没有指向任何实际对象（类似于一个空盒子）
            Customer c2;

            // 步骤3：通过 new 给 c2 实例化一个对象
            // 现在 c2 才真正指向内存中的一个 Customer 对象
            c2 = new Customer();

            // 步骤4：给 c1 这个对象的各个属性赋值
            c1.name = "Daniel";
            c1.address = "xxx xxxx xxxx";
            c1.age = 21;               
            c1.createTime = "1888-08-88"; 

            // 步骤5：调用 c1 的方法，显示这个顾客的信息
            c1.Show();
             */


            //Vehicle Car1 = new Vehicle();
            //Car1.Run();
            //Car1.Stop();


            Vector3 v1 = new Vector3();

            v1.x = 1.78f;
            v1.y = 6.6f;
            v1.z = 4.4f;

            float lenght = v1.Length();
            Console.WriteLine("向量长度：" + lenght);
        }
    }
}
