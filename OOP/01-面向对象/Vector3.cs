using System;
using System.Collections.Generic;
using System.Text;

namespace _01_面向对象
{
    internal class Vector3
    {
        public float x; public float y; public float z;

        public float Length() 
        {
            return (float)Math.Sqrt(x*x + y*y + z*z);
        }
    }
}
