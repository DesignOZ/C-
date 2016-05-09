using System;

namespace ConsoleApplication1
{

    public class Shape
    {
        protected string name;

        public Shape()
        {
            name = null;
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public void setname(string name)
        {
            this.name = name;
        }
    }
    
    public class Rectangle : Shape
    {
        private int width;
        private int height;
        private int res;

        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;            
        }

        public void setXY (int width, int height)
        {
            this.width = width;
            this.height = height;            
        }

        public void area()
        {
            res = width * height;
        }

        public void show()
        {
            Console.WriteLine(name + ", " + res);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.setname ("사각사각");
            rec.setXY (10, 20);
            rec.area();
            rec.show();
        }
    }
}
