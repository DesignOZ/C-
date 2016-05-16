using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160516
{
    // public sealed class마지막 클래스 (더이상 상속 진행되지 않음)
    // partial 분할된 클래스 (동일클래스명으로 작성)

    // * 인터페이스 (Interface)
    // 일반 클래스는 단일 상속이지만 인터페이스는 다중 상속이 가능.
    // 추상클래스와 비슷한 효과의 클래스, 인터페이스 내부에 메소드를 선언만 한다.
    // 구현은 인터페이스를 상속받은 클래스에서 한다.
    
    public class shape
    { }

    public class line
    {
        protected double res;
        public void show()
        {
            Console.WriteLine(res);
        }
    }

    public sealed partial class circle : line, shape
    {
        private int r;
        public void area()
        {

            res = r * r * 3.14592;
        }
    }

    public partial class circle : line, shape {
    }

    class object3
    {
        public void main()  {
        
        
        }
    }
}
