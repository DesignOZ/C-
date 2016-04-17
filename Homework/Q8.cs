using System;

namespace 문제_8
{
    class Program
    {
        static int Main(string[] args)
        {
            // 잘못된 알고리즘
            //int i = 0;
            //int p = 1;
            //int s = 1;
            //int sum = 0;

            //JUMP:

            //i = i + 1;
            //p = p * i;
            //sum = sum + (p * -s);


            //Console.WriteLine("i = " + i);
            //Console.WriteLine("p = " + p);
            //Console.WriteLine("s = " + s);
            //Console.WriteLine("sum = " + sum);
            //Console.WriteLine();

            //if (i < 10)
            //    goto JUMP;
            //else
            //    Console.WriteLine(sum); 

            int i;

            int SUM = 0;
            int P = 1;
            int S = -1;

            i = 1;
            JUMP:
            P = P * i;

            int SP = P * S;

            SUM = SUM + SP;

            Console.WriteLine("i = " + i);
            Console.WriteLine("P = " + P);
            Console.WriteLine("S = " + S);
            Console.WriteLine("SP = " + SP);
            Console.WriteLine("SUM = " + SUM);
            S = -S;

            i++;

            if (i <= 10)
                goto JUMP;
            else
            {
                Console.WriteLine("\n" + SUM);
                return 0;
            }
        }
    }
}
