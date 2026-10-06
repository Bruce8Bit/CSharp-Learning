using System;
using System.Collections.Generic;
using System.Text;

namespace _03_练习题
{
    internal class Device
    {
        public string Number;       // 设备编号 → 字符串
        public string Name;         // 设备名称 → 字符串
        public double Temperature;  // 温度 → 数字
        public double Efficiency;   // 效率 → 数字


        public bool IsHighTemperature()
        {
            if (Temperature > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsQualified()
        {
            if (Efficiency>=80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
