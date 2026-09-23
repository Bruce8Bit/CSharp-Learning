using System;
using System.Collections.Generic;
using System.Text;

namespace _01_面向对象
{
    internal class Customer
    {
        public string name;
        public string address;
        public int age;
        public string createTime;

        public void Show() 
        {
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("地址:" + address);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("创建时间:" + createTime);
        }
    }
}
