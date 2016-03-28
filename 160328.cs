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
        }
    }
}
