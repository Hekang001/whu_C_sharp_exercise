using System;

namespace day04_01_GenericLinkedList
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        
        //链表长度算法
        public int getLength(T t)
        {
            int length = 0 ;
            Node<T> n = new Node<T>(t);
            if (n.Next != null)
            {
                length++;
            }
            return length;
        }

        public void ForEach(Action<T> action)
        {
           /* Node <T> t = this.head;
            if (t != null)
            {
                action(t.Data);
                t = t.Next;
            }
            */
            for (Node<T> t = Head; t != null; t = t.Next)
            {
                action(t.Data);
            }
        }
     
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
          /*  for (Node<int> node = intlist.Head;
                  node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
         */
            //依次打印intlist中的元素
            intlist.ForEach(m => Console.WriteLine(m));

            //求最大值
            int max = int.MinValue;
            intlist.ForEach(m => { if (m > max) max = m; });
            Console.WriteLine($"最大值：{max}");

            //求最小值
            int min = int.MaxValue;
            intlist.ForEach(m => { if (m < min) min = m; });
            Console.WriteLine($"最小值：{min}");

            //求和
            int Sum = 0;
            intlist.ForEach(m => Sum += m);
            Console.WriteLine($"Sum：{Sum}");
           
            // 字符串型List
           /* GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for (Node<string> node = strList.Head;
                    node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
            */

        }

    }
}