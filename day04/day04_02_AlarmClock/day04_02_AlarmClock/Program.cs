using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace day04_02_AlarmClock
{
    //声明一个委托类型，定义事件处理函数
    public delegate void EventHandler(object sender, EventArgs args);

    public class EventArgs
    {
       public int Hour { get; set; }
       public int Minute { get; set; }
       public int Second { get; set; }
    }


    public class Button
    {
        //定义事件,创建一个委托实例
        public event EventHandler OnClick1;
        public event EventHandler OnClick2;

        public void RunTime()
        {
            //System.DateTime dateTime = new DateTime();
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            Console.WriteLine($"当前时间为 {hour}：{minute}:{second}");
            EventArgs args = new EventArgs()
            {
                Hour = hour,
                Minute = minute,
                Second =second
            };
            //触发onClick事件
            
              //  System.Threading.Thread.Sleep(1000);
                OnClick1(this, args);
 
        }

        public void Clock(int h,int m,int s)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            while (h == hour && minute == m && s == second)
            {
                Console.WriteLine($" {hour}：{minute}：{second} 到了");

                EventArgs args = new EventArgs()
                {
                    Hour = hour,
                    Minute = minute,
                    Second = second
                };

                OnClick2(this, args);
            }
        }
    }

    public class Form
    {
        public Button button1 = new Button();
        public Button button2 = new Button();

        public Form()
        {
            //为btn的OnClick事件添加两个处理方法
            button1.OnClick1 += new EventHandler(Btn_OnClick);
            button1.OnClick2 += new EventHandler(Btn_OnClick2);
           

        }

        void Btn_OnClick(object sender, EventArgs args)
        {
            Console.WriteLine("滴答滴答……");
        }

        void Btn_OnClick2(object sender, EventArgs args)
        {
            Console.WriteLine($"铃铃铃……该起床了");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                form1.button1.RunTime();//模拟点击按钮实现闹钟走时
                form1.button1.Clock(17, 3, 20);  
            }
        }
    }


}

