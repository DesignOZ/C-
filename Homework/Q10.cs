using System;

namespace 문제_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = -9999;
            int MIN = 9999;

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + "번 학생의 점수를 입력해주십시오.");
                string s_K = Console.ReadLine();
                int K = int.Parse(s_K);

                if (K > MAX)
                    MAX = K;                    // (1)

                if (K < MIN)                    // (2)
                    MIN = K;                    // (3)
            }

            Console.WriteLine("최고점은 " + MAX + "점이며, 최저점은 " + MIN + "점 입니다.");
        }
    }
}
