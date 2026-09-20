namespace Day13_编程题字符串
{
    internal class Program
    {
        /*
         
        //3个可乐瓶可以换⼀瓶可乐，现在有364瓶可乐，问⼀共可以喝多少瓶可乐，剩下⼏个空瓶。
        static void Main(string[] args)
        {
            int pingNumber = 364 ;
            int heNumber = 364 ;
            while (pingNumber > 2 ) 
            {
                heNumber += pingNumber / 3 ;
                pingNumber = (pingNumber / 3) +(pingNumber % 3) ;
            }
            Console.WriteLine("一共可以喝"+heNumber+"，剩下"+pingNumber);
        }

         */



        // 冒泡排序

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            { 
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }

            for (int j = 0; j < intArray.Length-1-j; j++)
            {
                for (int i = 0; i < intArray.Length-1; i++)
                {
                    if (intArray[i] > intArray[i +1]) // 如果左边>右边，进行交换
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i+1] = temp; 
                    }
                }
            }
            foreach (int temp in intArray)
            {
                Console.Write(temp+" ");
            }

        }
    }
}
