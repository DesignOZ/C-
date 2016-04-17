using System;

namespace 문제_4
{
    class Program
    {
        static int Main(string[] args)
        {
            int i = 1;

            JUMP:                       // if 결과가 false일 때 JUMP구간 반복.
            int k = 2;                  // k = (1)

            if (i % k == 0)             // if (k (2))
                Console.WriteLine(i);   // YES
            i++;
            if (i <= 100)               // if (i (3))
                goto JUMP;              // YES
            else
                return 0;               // NO
        }
    }
}
