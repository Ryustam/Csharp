using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyNamespace
{
    internal class Program //프로그램의 시작점
{
    public static void aaaa(string[] args) //java의 main인데, C#은 C와 마찬가지로 하나의 프로그램에 하나의 메인이 있다.
    {
        Console.WriteLine("aaaa!!!!!!!");
    }
}
}

namespace MyCsharp_0117
{
    internal class Program
    {
        static void aaaa(string[] args)//java의 main인데, C#은 C와 마찬가지로 하나의 프로그램에 하나의 메인이 있다.
        {
            Console.WriteLine("aaaa!");
        }

        static void Main(string[] args)//java의 main인데, C#은 C와 마찬가지로 하나의 프로그램에 하나의 메인이 있다.
        {
            Console.WriteLine("Hello");
            aaaa(null);
            MyNamespace.Program.aaaa(null);
        }
    }
}
