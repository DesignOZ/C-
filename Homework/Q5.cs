using System;

namespace 문제_5
{
    class Program
    {
        static int Main(string[] args)
        {
            int cnt, N, K, E, M, tot;
            double ave;
            string s_N, s_K, s_E, s_M;

            cnt = 0;

            JUMP:
            Console.WriteLine("입력하고자 하는 학생의 번호를 입력해 주십시오.");
            s_N = Console.ReadLine();
            N = int.Parse(s_N);

            Console.WriteLine(N + "번 학생의 국어 점수를 입력해 주십시오.");
            s_K = Console.ReadLine();
            K = int.Parse(s_K);

            Console.WriteLine(N + "번 학생의 영어 점수를 입력해 주십시오.");
            s_E = Console.ReadLine();
            E = int.Parse(s_E);

            Console.WriteLine(N + "번 학생의 수학 점수를 입력해 주십시오.");
            s_M = Console.ReadLine();
            M = int.Parse(s_M);

            if (N != 999)
            {
                tot = K + E + M;
                ave = (double)tot / 3;
                if (ave >= 90)
                {
                    cnt++;
                    goto JUMP;
                }
                else
                    goto JUMP;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("평균이 90점 이상인 학생은 " + cnt + "명 입니다.");
                return 0;
            }
                


        }
    }
}
