using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp_console02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escapse 문자
            Console.WriteLine("안녕 \"이동준\" 학생");
            //쌍따옴표 안에서 \(역슬러시) 출력
            Console.WriteLine("C:\\abc\\과제파일.pptx");
            //역슬러시는 골뱅이 활용해서 표시도 가능함
            Console.WriteLine(@"C:\abc\과제파일.pptx");

            //+연산 활용
            //1. 일반적인 덧셈연산(생략)
            //2. 문자열 이어붙이기
            Console.WriteLine("안녕"+"디지몬");
            Console.WriteLine("내 나이는"+34+"살이야");
            //3. 2번을 응용한 숫사를 문자열로 변환하기

            Console.WriteLine(10+100);
            Console.WriteLine(""+10+100);
            Console.WriteLine(10.ToString()+100);
            Console.WriteLine(10+100+""+200);

            //"" 이전에는 +하면 산술적으로 덧셈이 되시만, "" 이후에는
            //숫자를 더하면 문자열로서 글자가 더해짐

            Console.WriteLine(int.Parse(10+100+"")+(200+300));


            //문자열의 일부분을 가져오는 법
            string hello = "안녕하세요";
            string hello2 = "Hello Everyone";

            Console.WriteLine(hello[0]);
            Console.WriteLine(hello2[0]);

            string one = "472";
            string two = "385";
            
            //방법이 2개
            //char 값은 바로 숫자로 변환 가능
        
            int a=int.Parse(char.ToString(two[2]));

            Console.WriteLine(a*int.Parse(one));

            Console.WriteLine(char.GetNumericValue(two[2]) * int.Parse(one));

            Console.WriteLine("가"+"힣");

            Boolean t = false;
            bool tt = true;

            int b = 105;


            //위 if만 주석처리하면 중괄호는 크게 상관없다.
            if (b == 105)
            {
                Console.WriteLine("a는...");
                Console.WriteLine("105!!!");
            }

        }
    }
}
