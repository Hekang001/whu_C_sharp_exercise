using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02_03
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("2-100之间的所有素数有：");
            bool[] array = new bool[101];
            for (int i = 2; i <= 100; i++)
            {
                array[i] = true;
            }

            for (int i = 2; i <= 100; i++)
            {
                int num = 2;
                while (i * num <= 100)
                {
                    array[i * num] = false;
                    num++;
                }

                if (array[i] == true)
                    Console.Write(i + " ");
            }
            Console.WriteLine();


        }
    }
}
