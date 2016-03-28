using System;                                     // 자바의 Import와 같음.

public class ch02_01  {

  public static void Main(string[] args)  {
  
    System.Console.WriteLine("Hello");
    Console.WriteLine("Bye");                     // Using System으로 System 생략. cw 사용.

    // a와 b의 자리 바꾸기
    int a = 10;
    int b = 3;
    int temp;
    temp = a;
    a = b;
    b = temp;
      
    Console.WriteLine(a);
    Console.WriteLine(b);

    // bool 사용
    bool boolean = a > b;
    Console.WriteLine(boolean);

    if (b > a)
        Console.WriteLine("True!");               // 심심해서 해봄

    // string, char 사용
    string name = "OZ";
    char c = '가';

    Console.WriteLine(name);
    Console.WriteLine(c);

    // 숫자 3개를 입력하여 총점, 평균(실수)를 나타내시오.

    int i = 54;
    int j = 11;
    int k = 65;
    int sum = i + j + k;
    float m = (float)sum/3; 

    Console.WriteLine(i + j + k);
    Console.WriteLine(m);
    

    // 데이터 형식 바꾸기
    float n = 69.6875f;
    Console.WriteLine("n : {0}", n);

    double o = (double)n;
    Console.WriteLine("o : {0}", o);

    Console.WriteLine("69.6875 == o : {0}", 69.6875 == o);

    float x = 0.1f;
    Console.WriteLine("x : {0}", x);

    double y = (double)x;
    Console.WriteLine("y : {0}", y);

    Console.WriteLine("0.1 == y : {0}", 0.1 == y);


    // int to string
    string aa = "12345";
    int ab = int.Parse(aa);
    Console.WriteLine(ab);

    int ba = 12345;
    string bb = ba.ToString();
    Console.WriteLine(bb);


    // 두 수를 입력받아 두 수를 교체하라
    Console.WriteLine("첫번째 숫자를 입력해주세요.");
    string ca = Console.ReadLine();
    Console.WriteLine("두번째 숫자를 입력해주세요.");
    string cb = Console.ReadLine();

    int temp_a;
    int ci = int.Parse(ca);
    int cj = int.Parse(cb);
    temp_a = ci;
    ci = cj;
    cj = temp_a;

    Console.WriteLine("a = {0}, b = {1}", ci, cj);

    // 연산자를 사용하기
    int da = 10, db = 3;
    Console.WriteLine(da + db);
    Console.WriteLine(da - db);
    Console.WriteLine((float)da / db);
    Console.WriteLine((float)da % db);

    // 삼항 연산자, 비트 연산자
    int ea = 10, eb = 3, ec = 30;
    int max = (ea > eb) ? ea : eb;
    max = (max > ec) ? max : ec;
    Console.WriteLine("최댓값은 {0}이다.", max);
    Console.WriteLine(ea > eb && eb > ec);
    Console.WriteLine(ea > eb || eb > ec);
    Console.WriteLine(ea & eb);
    Console.WriteLine(ea | eb);
    Console.WriteLine(~ea+1);
    Console.WriteLine(~90+1);
  
    // if문 사용하기
    Console.WriteLine("숫자를 입력해주세요");
    string str = Console.ReadLine();
    int num = int.Parse(str);
    if (num % 2 == 0) Console.WriteLine("이 숫자는 짝수임");
    else if (num == 0) Console.WriteLine("0");
    else Console.WriteLine("홀수임");

    // 10을 3 으로 나눈 나머지를 a에 저장
    int fa = 10 % 3;
    int fb = 10 - 10 / 3 * 3;

    Console.WriteLine(fa);
    Console.WriteLine(fb);

    // x를 y로 나눈 나머지를 z에 저장
    Console.WriteLine("x값을 입력해주세요");
    string fc = Console.ReadLine();
    Console.WriteLine("y값을 입력해주세요");
    string fd = Console.ReadLine();
    int fe = int.Parse(fc);
    int ff = int.Parse(fd);
    int fg = fe % ff;
    int fh = fe - fe / ff * ff;


    // 점수를 입력받아서 90점 이상이면 A, 80점 이상이면 B, 70점 이상이면 C, 그 외는 F.
    Console.WriteLine("점수를 입력해주세요");
    string ga = Console.ReadLine();
    int gb = int.Parse(ga);

    if (gb >= 90) Console.WriteLine("A");
    else if (gb >= 80 && gb < 90) Console.WriteLine("B");
    else if (gb >= 70 && gb < 80) Console.WriteLine("C");
    else Console.WriteLine("F");

    // 위를 switch로.
    switch (gb/10)
    {
        case 10 :
            Console.WriteLine("A");
            break;
        case 9 :
            Console.WriteLine("A");
            break;
        case 8:
            Console.WriteLine("B");
            break;
        case 7:
            Console.WriteLine("C");
            break;
        default:
            Console.WriteLine("F");
            break;
            
    // 배열
            int[] am = new int[] {10, 20,  30, 40, 50};

            for (int an = 0 ; an < am.Length; an++)
                Console.WriteLine(am[an]);

            // 5개의 a배열을 잡아서 값을 콘솔로 입력받아 저장하시오. [과제]
            int[] ao = new int[5];
            int sum = 0, max = -9999;
            double avg = 0;
            
            for (int ap = 0; ap < ao.Length; ap++)
            {
                // 숫자를 입력받습니다.
                Console.WriteLine("숫자를 입력해주세요.");
                string aq_s = Console.ReadLine();
                ao[ap] = int.Parse(aq_s);
                
                // 입력받은 숫자를 합계(int sum)에 더합니다.
                sum += ao[ap];

                // 입력받은 숫자와 최댓값을 비교하고, 입력받은 숫자가 크면 대입합니다.
                if (ao[ap] > max)
                    max = ao[ap];
            }
            Console.WriteLine("a[0] = " + ao[0] + ", a[1] = " + ao[1] + ", a[2] = " + ao[2] + ", a[3] = " + ao[3] + ", a[4] = " + ao[4]);
            Console.WriteLine("합계\t= " + sum);
            Console.WriteLine("평균\t= " + (double) sum / ao.Length);
            Console.WriteLine("최댓값\t= " + max);
    }
  }
}
