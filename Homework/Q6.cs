using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 문제 6
            int S = 0;
            int SA = 0;
            int i;

            i = 0;
            JUMP:
            i = i + 1;
            SA = SA + i;
            S = S + SA;

            Console.WriteLine(S);
            Console.WriteLine(SA);
            Console.WriteLine(i);
            Console.WriteLine();

            if (i < 10) goto JUMP;
            else Console.WriteLine(S);
            
        }
    }
}
