using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160328
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-100까지 수를 출력 (while)
            int aa = 1;
            while (aa <= 100)
            {
                Console.WriteLine(aa);
                aa++;
            }


            // 1-100까지 수를 출력 (for)
            
            for (int ab = 1 ; ab <= 100 ; ab ++)
                Console.WriteLine(ab);


            // 1-100까지 수를 출력 (do-while)
            int ac = 1;
            do
            {
                Console.WriteLine(ac);
                ac++;
            } while (ac < 100);
            Console.WriteLine(ac);
            
            // 다중 for문 이용
            for (int ae = 1; ae <= 6; ae++)
            {
                for (int af = 1; af <= ae; af++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            
            Console.WriteLine();
            // 다중 for문 이용 (역)

            for (int ag = 6; ag >= 1; ag--)
            {
                for (int ah = ag; ah >= 1; ah--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            
            Console.WriteLine();
            // 다중 for 이용 (aj <= 4)

            for (int ai = 1; ai <= 6; ai++)
            {
                for (int aj = 1; aj <= ai & aj <= 4; aj++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // 1-10까지 출력하되, 3의 배수를 제외한 숫자만 출력

            for (int ak = 1; ak <= 10; ak++)
            {
                if (ak % 3 == 0) continue;
                Console.WriteLine(ak);
            }

            Console.WriteLine();
            // GOTO문 사용하기 (권장하지 않음);

            int al = 0;

        start:
            if (al > 10) goto JUMP;

            Console.WriteLine(al);
            al++;
            goto start;

        JUMP:
            Console.WriteLine("끝!");
        }
    }
}
