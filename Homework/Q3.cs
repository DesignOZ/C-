using System;

namespace 문제_3
{
    class Program
    {
        static int Main(string[] args)
        {
            int i = 101;                // i = (1)

            JUMP:                       // if 결과가 true일 때 JUMP구간 반복.
            if (i != 0)                 // if (i (2))
            {                           // YES
                i--;                    // i = (3), i = i - 1와 같음.
                Console.WriteLine(i);
                goto JUMP;
            }
            else                        // NO
                return 0;
        }
    }
}
