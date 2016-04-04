using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160404
{
    class a201205018_박호령
    {
        void sum()
        {
            int i, sum = 0;
            for (i = 1; i <= 100; i++)
                sum = ++sum;

            Console.WriteLine(sum);

            return;
        }

        void sum(int n)
        {
            int i, sum = 0;
            for (i = 1; i <= n; i++) sum += ++sum;

            Console.WriteLine(sum);

            return;
        }
        static void Main(string[] args)
        {

            // 1차원 배열

            int[] aa = new int[10];                         // 정수 10개를 가질 수 있는 정수형 배열을 선언.


            // 오름차순 정렬
            Console.WriteLine("오름차순 정렬");
            int[] ac = new int[5] { 15, 6, 100, 20, 50 };   // 정수값이 1차원 배열에 저장되어있다.


            //Bubble Sort

            int count_a = 0, count_b = 0;                   // 반복문 진행횟수(단계 진행)는 카운터가 체크한다.
            int temp;

            for (int i = 0; i < ac.Length - 1; i++)
            {

                for (int j = 0; j < ac.Length - 1; j++)
                {
                    if (ac[j] > ac[j + 1])
                    {

                        temp = ac[j];
                        ac[j] = ac[j + 1];
                        ac[j + 1] = temp;
                    }
                    count_b++;

                }
                count_a = i + 1;
            }

            // 정렬한 배열을 출력한다.
            for (int i = 0; i < ac.Length; i++) Console.Write(ac[i] + "\t");


            // 단계를 체크하던 카운터를 출력한다.
            Console.Write("비교한 횟수 = " + count_b + "\t");
            Console.WriteLine("단계  = " + count_a);


            // 이미 정렬된 배열에 대한 개선 알고리즘
            Console.WriteLine("\n" + "개선된 오름차순 정렬");

            int[] ad = new int[5] { 15, 6, 100, 20, 50 };

            int s = 0;                                      // 스위치와 추가한다
            // 한번이라도 정수 교체를 한 경우 스위치값이 1이 되기 때문에 반복문을 계속 진행하게 된다.
            // 하지만 한번이라도 교체가 진행되지 않으면 반복문을 빠져나오게 된다.

            s = 0;
            count_a = 0; count_b = 0;

            for (int i = 0; i < ac.Length - 1; i++)
            {
                s = 0;
                for (int j = 0; j < ac.Length - 1; j++)
                {
                    if (ad[j] > ad[j + 1])
                    {

                        temp = ac[j];
                        ad[j] = ad[j + 1];
                        ad[j + 1] = temp;
                        s = 1;
                        count_b++;
                    }


                }
                if (s == 0)
                    break;
                count_a = i + 1;

            }


            for (int i = 0; i < ac.Length; i++) Console.Write(ac[i] + "\t");    // 정렬한 배열을 출력한다.

            Console.Write("비교한 횟수 = " + count_b + "\t");
            Console.WriteLine("단계  = " + count_a);                            // 단계를 체크하던 카운터를 출력한다.



            // 2차원 배열
            Console.WriteLine("\n" + "2차원 배열");
            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }


            // 과제 (내림차순)

            Console.WriteLine("\n" + "내림차순, 석차");

            int[,] af = new int[2, 5] { { 1, 1, 1, 1, 1 }, { 90, 60, 100, 20, 60 } };   // 2차원 배열 생성

            count_a = 0; count_b = 0;


            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (af[1, k] < af[1, k + 1])
                    {
                        temp = af[1, k];
                        af[1, k] = af[1, k + 1];
                        af[1, k + 1] = temp;

                    }
                }
            }

            int rank = 1;
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                    af[0, i] = rank;
                
                else if (af[1, i] > af[1, i + 1])
                    af[0, i] = rank++;
                else
                    af[0, i] = rank;
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(af[i, j] + "\t");
                }
                Console.WriteLine();
            }


            // 메서드 함수
            int ia = 10, ib = 20;
            Console.WriteLine(ia + ", " + ib);
            swap(ia, ib);

        }

        static void swap(int a, int b)  {
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + ", " + b);
        }
    }
}
