using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _160404
{
    class a201205018_박호령
    {
        static void Main(string[] args)
        {

            // 1차원 배열

            int[] aa = new int[10];                         // 정수 10개를 가질 수 있는 정수형 배열을 선언.
            

            // 오름차순 정렬

            int[] ac = new int[5] { 15, 6, 100, 20, 50 };  // 정수값이 1차원 배열에 저장되어있다.
            
            //Bubble Sort
            int temp;
            for (int i = 0; i < ac.Length-1; i++)
			{
                for (int j = 0; j < ac.Length-1; j++)
                {
                    if (ac[j] > ac[j + 1])  {

                    temp = ac[j];
                    ac[j] = ac[j + 1];
                    ac[j + 1] = temp;
                    }
                        
                }
                    

			}
            
            // 정렬한 배열을 출력한다.
            for (int i = 0; i < ac.Length; i++)
            {
                
                Console.Write(ac[i]+"\t");
            }
            
            // 이미 정렬된 배열에 대한 개선 +알고리즘
            // int[] ad = new int[] 

            int[] ad = new int[5] { 15, 6, 100, 20, 50 };   // 정수값이 1차원 배열에 저장되어있다.

            //Bubble Sort
            
            //int temp;
            int s = 0;                                      // 스위치와 카운터를 추가한다.
            int count = 0;                                  // 한번이라도 정수 교체를 한 경우 스위치값이 1이 되기 때문에 반복문을 계속 진행하게 된다.
                                                            // 하지만 한번이라도 교체가 진행되지 않으면 반복문을 빠져나오게 된다.
                                                            // 반복문 진행횟수 (단계 진행)는 카운터가 체크한다.
            
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
                    }
                    
                }
                if (s == 0)
                    break;
                count = i+1;
                
            }
            Console.WriteLine("단계  = " + count);
            
        }
    }
}
