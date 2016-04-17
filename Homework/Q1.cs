using System;

namespace 문제_1
{
    class Program
    {
        static int Main(string[] args)
        {
            int i = 2;                  // i = (1)
          // ↓
            JUMP:
          // ↓
            Console.WriteLine(i);
          // ↓
            i += 2;                     // i = (2)
          // ↓
            if (i <= 100)               // if (i (3) 100)
                goto JUMP;              // YES
            else
                return 0;               // NO

        }
    }
}
