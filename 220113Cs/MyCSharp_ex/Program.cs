using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mykg=int.Parse(Console.ReadLine());
            Console.WriteLine($"{mykg}kg={mykg*2.20462262}pound");

            Console.WriteLine("원의 반지를");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"원의둘레={r*3.14*2}");

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine();


        }
    }
}
