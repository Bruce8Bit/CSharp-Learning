using System;
using System.Collections.Generic;
using System.Text;

namespace _01_面向对象
{
    internal class Vehicle
    {
        public int Speed;
        public int maxSpeed;
        public double Weight;


        public void Run() 
        {
            Console.WriteLine("车辆启动");
        }

        public void Stop() 
        {
            Console.WriteLine("车辆停止");
        }
    }
}
