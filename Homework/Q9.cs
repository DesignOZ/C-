using System;

namespace 문제_9
{
    class Program
    {
        static int Main(string[] args)
        {

            double S = 0;                               // (1)
            int SA = 0;
            int SC = 0;
            int SW = 0;

            int i = 1;                                  // (2)

            JUMP:
            SA = SA + i;                                // (3)

            if (SW == 0)                                // (4)
            {
                SC = SC + i;                            // (5)
                S = S + (Double)SC / (Double)SA;
                SW = 1;
            }
            else
            {
                SC = SC - i;
                S = S - (Double)SC / (Double)SA;        // (6)
                SW = 0;                                 // (7)
            }

            Console.WriteLine("i = " + i);
            Console.WriteLine("SA = " + SA);
            Console.WriteLine("SC = " + SC);
            Console.WriteLine("SW = " + SW);
            Console.WriteLine("S = " + S + "\n");
            i++;

            if (i <= 10) goto JUMP;
            else
            {
                Console.WriteLine(S);                    // (8)
                return 0;
            }
        }
    }
}
