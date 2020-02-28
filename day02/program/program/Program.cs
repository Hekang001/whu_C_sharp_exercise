using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static bool isPrimer(int num)
        {
            double m = System.Math.Sqrt(num);//此为求平方根
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字：");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("素数因子为：");
            for (int i =2; i <= input;i++)
            {
                
                if (input % i == 0 && isPrimer(i))
                {
                    Console.WriteLine(i);
                    input = input / i;
                }

            }

        }
    }
}

    