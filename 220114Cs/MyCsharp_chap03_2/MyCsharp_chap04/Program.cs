using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharp_chap04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //region : 영역
            //alt + 방향키
            if (false)
            {
                #region MyRegion
                int[] myarr = { 10, 100, -500 }; //3칸짜리배열
                int[] myarr_2 = new int[10];  //10칸짜리 배열

                Console.WriteLine(myarr.Length);

                int[,] myarr_2_dim = { { 10, 20, 30 }, { 40, 50, 60 } };
                //Cs의 2차원배열 선언 방법
                int[,] myarr_2_dim_2 = new int[2, 3];


                int count = 0;
                while (count < myarr.Length)
                {
                    Console.WriteLine(myarr[count]);
                    count++;
                }

                do
                {
                    Console.WriteLine("count값은 " + count + "입니다");
                } while (count < myarr.Length);




                int sum = 0;

                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);


                int sum2 = 0;

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int obj1 = (num1 > num2) ? num1 : num2;
                int obj2 = (num1 > num2) ? num2 : num1;

                for (int i = obj2; i <= obj1; i++)
                {
                    if (i % 3 == 0)
                    {
                        sum2 += i;
                    }
                }
                Console.WriteLine(sum2);

                for (char i = 'A'; i <= 'z'; i++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();

                string input = "";
                do
                {
                    Console.WriteLine("계속 입력");
                    input = Console.ReadLine();

                } while (!input.Equals("exit"));


                int max = 0;
                int min = 0;
                int num3 = 0;

                for (int i = 0; i < 5; i++)
                {
                    num3 = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        min = num3;
                    }
                    max = (num3 > max) ? num3 : max;
                    min = (num3 < min) ? num3 : min;
                }
                Console.WriteLine(max);
                Console.WriteLine(min);


                int[] Arr = { 6, 7, 15, 67, 3 };

                Array.Sort(Arr);

                for (int i = 0; i < Arr.Length; i++)
                {
                    Console.WriteLine(Arr[i]);
                }

                int[] Arr2 = { 6, 7, 15, 67, 3 };

                for (int i = 1; i < Arr2.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (Arr2[i] < Arr2[j])
                        {
                            int temp = Arr2[i];
                            Arr2[i] = Arr2[j];
                            Arr2[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < Arr2.Length; i++)
                {
                    Console.WriteLine(Arr2[i]);
                }
                #endregion
            }

            if (false)
            {

                #region ant

            
            string numbers = "11";
            string clone = "";
            int count_this=1;
            
            for (int i = 0; i < 18; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    
                    int a = int.Parse(char.ToString(numbers[j]));  
                    

                    if (j == 1) 
                    {
                        clone = clone + int.Parse(char.ToString(numbers[0]));
                    }

                    if (int.Parse(char.ToString(numbers[j-1])) == a)
                    {
                        count_this++;

                        if (j == numbers.Length-1)
                        {
                            clone = clone + count_this.ToString();
                        }
                    }
                    else
                    {
                        clone = clone + count_this.ToString();
                        clone = clone + a.ToString();
                        count_this = 1;
                        if(j==numbers.Length-1)
                        {
                            clone = clone + count_this.ToString();
                        }
                    }
                }
                numbers = clone;
                clone = "";
                count_this = 1;
                Console.Write(i+3+"번째:  ");
                Console.WriteLine(numbers);
            }

            #endregion

            }
            /*
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "goto")
                    goto myant;
            }

            Console.WriteLine("goto 이동시 이 부분은 생략되요.");

        myant:
            Console.WriteLine("내가 원하는 지점");
            */




            string example = " DongJoonLee@선생님!C#담당";

            string[] result1 = example.Split('@');
            Console.WriteLine(result1[0]);
            Console.WriteLine(result1[1]);
            string[] result2 = example.Split(new char[] { '@','!'});
            Console.WriteLine(result2[0]);
            Console.WriteLine(result2[1]);
            Console.WriteLine(result2[2]);

            string joinResult = string.Join(",", result2);
            Console.WriteLine(joinResult);
        }
    }
}
