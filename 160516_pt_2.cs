using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160516
{
    // *추상클래스 (설계도임, 메모리 할당이 안됨)
    // * public abstract class 클래스명 {}

    // public abstract class ASDF {}
    // ASDF asdf = new ASDF; (X)

    // public class ABCD : ASDF
    // ABCD abcd = new ABCD; (O)

    // * 추상메소드 (구현하지 않고, 상속받은 자식이 구현해야함)
    // 부모 메소드에서 추상메소드를 정의, 자식 메소드에서 구현.

    // ↓ 부모
    public abstract class car
    {
        protected string type;
        protected string color;
        protected int hp;

        public car()
        {
            type = null;
            color = null;
            hp = 0;
        }

        public void setInfo(string type, string color, int hp)    // 일반메소드라 구현됨.
        {
            this.type = type;
            this.color = color;
            this.hp = hp;
        }

        public void show()
        {
            Console.WriteLine(type + ", " + color + ", " + hp);
        }

        public abstract void ashow();                           // 추상메소드라 구현되지 않음.

    }

    // ↓ 자식
    public class taxi : car
    {
        protected int count;

        public void prn()
        {
            Console.WriteLine(count);
        }

        public override void ashow()                            
        {
        }
    }

    class object2
    {
        static void Main()
        {
            // car c = new car();안됨.
            taxi t = new taxi();
            t.setInfo("Taxi", "RED", 50);
            t.ashow();
            t.prn();
            t.show();

        }
    }

}
