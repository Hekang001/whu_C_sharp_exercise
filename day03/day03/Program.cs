using System;

namespace day03
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Triangle 0 ; Rectangle 1;Circular 2;");

            BaseShape shape1 = new Triangle(3,4);
            BaseShape shape2 = new Rectangle(4, 4);
            BaseShape shape3 = new Circular(5.8);

           // Console.WriteLine("The area of triangle is " + shape1.GetArea());

            int[] number = new int[10];
            Random a = new Random();
            double sumArea = 0;
            for (int i =0; i < 10; i++)
            {
                number[i] = a.Next(1, 4);
                Console.WriteLine("name:" + number[i]);
                Console.WriteLine("area is " + ShapeFactory.GetBaseShape(number[i]).GetArea());
                sumArea += ShapeFactory.GetBaseShape(number[i]).GetArea();
            }
            Console.WriteLine("The area of the ten base shape is " + sumArea);
            // Console.ReadKey();
        }
    }


    public interface BaseShape
    {
        double  GetArea();
        bool isLegal();
    } 

 //三角形
    class Triangle : BaseShape 
    {
        public double height, weight;

        public Triangle()
        {

        }

        public Triangle(double x,double y)
        {
            this.height = y;
            this.weight = x;
        }

        public bool isLegal()
        {
            if (height < 0 || weight <0)
                return false;
            else
                return true;
        }

        public double GetArea()
        {
            if (isLegal())
                return height * weight * 1 / 2;
            else
                return -1;
        }  
    }

//矩形
    class Rectangle : BaseShape
    {
        private double length, weight;

        public Rectangle()
        {

        }

        public Rectangle(double x, double y)
        {
            this.length = y;
            this.weight = x;
        }

        public bool isLegal()
        {
            if (length < 0 || weight < 0)
                return false;
            else
                return true;
        }

        public double GetArea()
        {
            if (isLegal())
                return length * weight;
            else
                return -1;
        }
    }
    
    //圆形
    class Circular : BaseShape
    {
        public double radius;

        public Circular()
        {

        }

        public Circular(double radius)
        {
            this.radius = radius;
        }

        public bool isLegal()
        {
            if (radius <0)
                return false;
            else
                return true;
        }

        public double GetArea()
        {
            if (isLegal())
                return System.Math.PI * radius * radius;
            else
                return -1;
        }
    }

    //工厂类 
    class ShapeFactory
    {
       
        public static BaseShape GetBaseShape(int number )
        {
            //BaseShape baseShape = null;

            switch (number)
            {
                case 1:
                    return new Triangle(3,8);
                case 2:
                    return new Rectangle(2,4);
                case 3:
                    return new Circular(5.8);
            }
            return null;
        }
    }
}
