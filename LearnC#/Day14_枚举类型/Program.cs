namespace Day14_枚举类型
{
    enum weekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            weekDay day = weekDay.Monday;
            int d = (int)weekDay.Monday; //强制类型转换
        }
    }
}
