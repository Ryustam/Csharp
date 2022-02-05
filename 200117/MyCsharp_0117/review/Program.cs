using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("printf나 System.out.println과 똑같은거다.");
            Console.WriteLine("printf(\"\\n\");");
            Console.WriteLine(@"\");

            // \: escapse 문자 활용도
            // 문자열 안에 쌍따옴표 삽입시
            // 파일 경로 전송시 (C:\appData\Game...);
            // 쌍따옴표 앞에 @ 붙이면 \자체가 기능을 잃음. 그냥 하나의 문자로 취급.
            // 그래서 \ 이용해서 쌍따옴표등 출력할 경우엔 @는 안 쓰는게 좋다.

            //System.out.print 혹은 printf("") 같은 걸 쓰고 싶다면
            Console.Write("");  //WriteLine은 출력하고 한 줄 띄우지만, Write는 안 띄움

            Console.WriteLine("자동완성이 좋다.");

            const int CNT = 10;
            Console.WriteLine(CNT);
            string abc = "a@b@c";

            String[] aaa = abc.Split('@');   //문자열을 @기준으로 짜르기
            String total = String.Join(",", aaa); //문자열 배열을 , 로 합치기
            Console.WriteLine(total);

            string hello = "안녕하세요";
            string hello2 = "hello world";
            char mytest = '안';

            Console.WriteLine(hello[0]);
            Console.WriteLine(hello2[0]);
            Console.WriteLine(mytest);
            Console.WriteLine(hello[0]+hello2[0]);
            Console.WriteLine(""+hello[0] + hello2[0]);

            //문자열 덧셈 : 글자 이어붙이기

            Console.WriteLine("char: "+ sizeof(char));

            int a = 10;
            Console.WriteLine( ++a + a++ + "" + ++a + a++);

            foreach(string c in aaa)
            {
                Console.WriteLine(c);
            }
            /*
            string output = Console.ReadLine();
            Console.WriteLine(output);

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input+100);
            Console.WriteLine(input.ToString()+ 100.ToString());

            //int.Parse는 문자열을 숫자로 바꿔주는 코드(단, 공백이나 문자열은 한글로 못바꿈)
            //ToString() = 문자열로 바꿔줌

            Console.WriteLine();


            Console.ReadLine();
            int.Parse(Console.ReadLine()); 
            int.TryParse(Console.ReadLine(), out int ex);
            */


            int[] test = { 1, 2, 3, 4 };
            foreach(var item in test)
            {
                Console.WriteLine(item);
            }
            //단점 ... item을 바꾼다고 해서, 배열 에 있는 값이 실제로 바뀌지않음.
            //for문 같은 경우엔 test[i] =0; 요렇게쓰면 i 번째가 진짜 0이 됨
            //'인덱스'를 반복문 수행 중에 활용할 방법이 없다. 별도의 변수 선언 필요..
            //결론 : 기능면에서 for문이 더 좋긴한데, 배열 안에 있는 값을 그냥 쭉 
            //출력하고 단순한 연산에선
            //foreach문도 괜찮다.
        }
    }
}
