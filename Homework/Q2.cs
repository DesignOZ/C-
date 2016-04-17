using System;

namespace 문제_2
{
    class Program
    {
        static int Main(string[] args)
        {
            int i = 3;                  // i = (1)
          JUMP:                         // if 결과가 false일 때 JUMP구간 반복.
          // ↓
            Console.WriteLine(i);
          // ↓
            i += 3;                     // i = (2), i = i + 3와 같음.
          // ↓
            if (i > 100)                // if (i (3))
                return 0;               // YES
            else
                goto JUMP;              // NO
        }
    }
}
