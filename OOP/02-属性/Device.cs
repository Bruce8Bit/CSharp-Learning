using System;
using System.Collections.Generic;
using System.Text;

namespace _02_属性
{
    internal class Device
    {
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

    }
}
