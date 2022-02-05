using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp_deep
{
    public class Parent
    {
        public int Id { get; set; }
        public void Method() //하이딩 될 것
        {
            Console.WriteLine("Hello");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Good Bye");
        } //오버라이딩 될 것
    }
}
