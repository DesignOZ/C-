using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160516
{
    // 상속 방법
    // class 자식클래스명 : 부모클래스명

    // * base의 의미.
    // 생성자 메소드 () : base()    {}
    // 부모의 생성자를 실행하라.

    // 생성자 메소드 () : base (x, y)    {}
    // 부모의 매개변수가 2개인 생성자를 실행하고 자신을 초기화하라.

    // base.show(); 부모의 show()메소드를 실행하라.

    public class parentClass
    {
        protected int px, py;

        public parentClass()
        {
            px = 0;
            py = 0;
        }

        public parentClass(int px, int py)
        {
            this.px = px;
            this.py = py;
        }

        public void setX(int px)
        {
            this.px = px;
        }

        public void setY(int py)
        {
            this.py = py;
        }

        public void show()
        {
            Console.WriteLine("부모 = " + px + ", " + py);
        }

    }

    public class childClass : parentClass
    {
        protected int cz;

        public childClass()
        {
            py = 0;
        }

        public childClass(int cz)
            : base(100, 100)
        {
            this.cz = cz;
        }

        public childClass(int px, int py, int cz)
            : base(px, py)
        {
            this.cz = cz;
        }


        public void draw()
        {
            base.show();
            Console.WriteLine("자식 = " + cz);

        }

    }

    class object1
    {
        static void Main(string[] args)
        {
            childClass c = new childClass(500);

            c.draw();

        }
    }
}
