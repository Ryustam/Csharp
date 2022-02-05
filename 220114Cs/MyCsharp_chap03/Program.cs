using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp_chap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 점입니까?");

            //0~50점: 밥없음
            //51~80: 밥줌
            //81~100:졸업

            int score = 49;

            if(0<=score && score <= 50)
            {
                Console.WriteLine("밥없음");
            } 
            else if(51 <= score && score <= 80)
            {
                Console.WriteLine("밥줌");
            }
            else
            {
                Console.WriteLine("졸업");
            }

            int month = 10;
            switch (month)
            {
                case 1:
                    Console.WriteLine("1월입니다.");
                    break;
                case 10:
                    Console.WriteLine("10월입니다.");
                    break;
                default:
                    Console.WriteLine(month+"월입니다. 1월도 아니고 10월도 아니에요.");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break ;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    break;
            }

            int test = 3;
            bool isEven = (test % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

            // contains()

            if ("안녕하세요".Contains("안녕"))
            {
                Console.WriteLine("인사했다.");
            }
            if ("Hello World".Contains("hello")) //hello 와 Hello는 서로 다른 문자로 인식
            {
                Console.WriteLine("영어인사");
            }

            int a = DateTime.Now.Year;

            Console.WriteLine(a%12);

            switch (a%12)
            {
                case 1:
                    Console.WriteLine("닭띠");
                    break;
                case 2:
                    Console.WriteLine("개띠");
                    break;
                case 3:
                    Console.WriteLine("돼지띠");
                    break;
                case 4:
                    Console.WriteLine("쥐띠");
                    break;
                case 5:
                    Console.WriteLine("소띠");
                    break;
                case 6:
                    Console.WriteLine("호랑이띠");
                    break;
                case 7:
                    Console.WriteLine("토끼띠");
                    break;
                case 8:
                    Console.WriteLine("용띠");
                    break;
                case 9:
                    Console.WriteLine("뱀띠");
                    break;
                case 10:
                    Console.WriteLine("말띠");
                    break;
                case 11:
                    Console.WriteLine("양띠");
                    break;
                case 0:
                    Console.WriteLine("원숭이띠");
                    break;
                default:
                    break;
            }

            int M = DateTime.Now.Month;

            if ((M %12) < 3)
            {
                Console.WriteLine("겨울");
            }
            else if ((M % 12) < 6)
            {
                Console.WriteLine("봄");
            }
            else if ((M % 12) < 9)
            {
                Console.WriteLine("여름");
            }
            else if ((M % 12) < 12)
            {
                Console.WriteLine("가을");
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다.");
            }

            //int Year = DateTime.Now.Year;
            int Year = 1995;

            int gab = Year % 10;
            int ja = Year % 12;

            switch (gab)
            {
                case 0:
                    Console.Write("경");
                    break;
                case 1:
                    Console.Write("신");
                    break;
                case 2:
                    Console.Write("임");
                    break;
                case 3:
                    Console.Write("계");
                    break;
                case 4:
                    Console.Write("갑");
                    break;
                case 5:
                    Console.Write("을");
                    break;
                case 6:
                    Console.Write("병");
                    break;
                case 7:
                    Console.Write("정");
                    break;
                case 8:
                    Console.Write("무");
                    break;
                case 9:
                    Console.Write("기");
                    break;
                default:
                    break;
            }

            switch (ja)
            {
                case 0:
                    Console.WriteLine("신년");
                    break;
                case 1:
                    Console.WriteLine("유년");
                    break;
                case 2:
                    Console.WriteLine("술년");
                    break;
                case 3:
                    Console.WriteLine("해년");
                    break;
                case 4:
                    Console.WriteLine("자년");
                    break;
                case 5:
                    Console.WriteLine("축년");
                    break;
                case 6:
                    Console.WriteLine("인년");
                    break;
                case 7:
                    Console.WriteLine("묘년");
                    break;
                case 8:
                    Console.WriteLine("진년");
                    break;
                case 9:
                    Console.WriteLine("사년");
                    break;
                case 10:
                    Console.WriteLine("오년");
                    break;
                case 11:
                    Console.WriteLine("미년");
                    break;
                default:
                    break;
            }


            Console.WriteLine("종료하고 싶으면 아무거나 입력하고 엔터를 치세요");

            Console.ReadLine(); //cr
        }
    }
}
