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
        

        public Customer() 
        {
            Console.WriteLine("这是一个构造函数！");
        }
        // 构造函数
        //public Customer(string arg1, string arg2, int arg3, string arg4)
        //{
        //    name = arg1; // 赋值。右→左  等号右边的值赋予左边
        //    address = arg2;
        //    age = arg3;
        //    createTime = arg4;
        //}

        public Customer(string name,string address,int age,string createTime)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.createTime = createTime;
        }


        public void Show() 
        {
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("地址:" + address);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("创建时间:" + createTime);
        }
    }
}
