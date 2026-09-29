using System;
using System.Collections.Generic;
using System.Text;

namespace _02_属性
{
    internal class Device
    {
        //private string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}

        private int temperature;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set 
            {
                if (value>=0 && value<=100)
                {
                    temperature = value;
                }
            }
        }

        public string Number
        {
            get; //外部可读
            private set;// 外部不可修改
        }
        public Device(string number)
        {
            Number = number;
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }
        

    }
}
