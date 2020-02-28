using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_02
{
    class Program
    {
       static void Sum(int [] array) //求和函数
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum +=array[i];
            }
            int average = sum / array.Length;

        Console.WriteLine("该数组的和是：" + sum);
        Console.WriteLine("该数组的平均数是：" + average);
        }

      static void Min_Max( int[] array)
        {
          System.Array.Sort(array);
            int min = array[0];
            int max = array[array.Length-1];
            Console.WriteLine("该数组的min是：" + min);
            Console.WriteLine("该数组的max是：" +max);
        }
     
        static void Main(string[] args)
        {
            int[] array;
            Console.WriteLine("请输入数字 enter结束：");

            int[] a =new int[] { 5, 8, 7, 6, 9, 11, 14,1,12 };
            Sum(a);
            Min_Max(a);
        }
    }
}
