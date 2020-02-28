using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入要运算的数字和运算符
            Console.WriteLine("请输入数字A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            string operate = Console.ReadLine();
            Console.WriteLine("请输入数字B");
            double B = Convert.ToDouble(Console.ReadLine());
            //将结果存储到变量D里面
            double D = 0;
            //用if条件语句判断输入的符号而进行相应的运算并输出
            if (operate == "+")
            {
                D = A + B;
                Console.WriteLine("A+B=" + D);
            }
            else if (operate == "-")
            {
                D = A - B;
                Console.WriteLine("A-B=" + D);
            }
            else if (operate == "*")
            {
                D = A * B;
                Console.WriteLine("A*B=" + D);
            }
            else if (operate == "/")
            {
                if (B == 0)
                {
                    Console.WriteLine("不能除零操作！");
                }
                else
                {
                    D = A / B;
                    Console.WriteLine("A/B=" + D);
                }

            }
            else if (operate == "")
            {
                Console.WriteLine("The operator is null");
            }
            else
            {
                Console.WriteLine("The operator is illegal");
            }
               
        }
    }
}