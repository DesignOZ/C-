using System;

namespace _160502
{
    // 클래스 예제
    class RedbeanFishBread
    {
        protected int mold;                             // (2-3)
        protected int flour;
        protected int redbean;

        public RedbeanFishBread()                       // (4)
        {
            mold = 0;
            flour = 0;
            redbean = 0;
        }

        public RedbeanFishBread(int flour, int redbean) // (1), (4)
        {
            mold = 0;
            this.flour = 0;
            this.redbean = 0;
        }

        public void set(int flour, int redbean)         // (3)
        {
            this.flour = flour;
            this.redbean = redbean;
        }
        
        public void make ()    {                        // (1)
            mold = flour + redbean + flour;
        }

        public void make(int choucream)                 // (1)
        {
            mold = flour + choucream + flour;
        }

        public void pull()
        {
            Console.WriteLine(mold);
        }
    }

    class wallnutbread : RedbeanFishBread
    {
        private int wallnut;                            // (2-1)

        public wallnutbread() {
            flour = 0;                                  // (2-3)
            mold = 0;
            wallnut = 0;
        }

        public void make()                              // (5)
        {
            mold = flour + redbean + wallnut + flour;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. 오버로딩 : 메소드 이름을 동일, 매개변수에 따라 호출하는 함수가 다름.");
            Console.WriteLine("2. 접근지정자 :");
            Console.WriteLine("\tpublic\t\t- 일반 메서드에는 일반적으로 public을 붙임.");
            Console.WriteLine("\tprivate\t\t- 변수에는 private를 붙이는게 원칙");
            Console.WriteLine("\tprotected\t- 자식클래스에서 부모클래스의 변수 또는 메서드를 사용하기위함.");
            Console.WriteLine("3. 값 전달을 위해 set 메서드를 만든다.");
            Console.WriteLine("4. 생성시에 값을 초기하기위해 생성자 메서드를 만든다.");
            Console.WriteLine("5. 부모의 메서드와 자식의 메서드가 동일할 때 자식의 메서드 사용. (오버라이딩)");
            RedbeanFishBread RFB = new RedbeanFishBread();
            wallnutbread WB = new wallnutbread();

        }
    }
}
