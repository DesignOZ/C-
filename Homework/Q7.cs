using System;


namespace 문제_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0, SA = 0, SW = 0;
            int i;

            i = 1;
            JUMP:
            SA = SA + i;

            if (SW % 2 == 0)
            {
                S = S - SA;
                SW = 1;
            }
            else
            {
                S = S + SA;
                SW = 0;
            }

            Console.WriteLine(S);
            Console.WriteLine(SA);
            Console.WriteLine(SW);
            Console.WriteLine(i);
            Console.WriteLine();
            i = i + 1;

            if (i <= 10)
                goto JUMP;
            else Console.WriteLine(S);
        }
    }
}
