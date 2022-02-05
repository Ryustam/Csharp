using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLastConsoleProject
{
    internal class Mobile : Product
    {
        public string modelName { get; set; } //Product가 갖는 속성뿐 아니라, modelName이라는 새로운 속성도 갖고 있음
        public void Call()  //product가 갖는 함수 뿐 아니라, call이라는 새로운 메서드도 갖고 있음

        {
            Console.WriteLine(modelName+"전화기로 전화를 합니다.");
        }
    }
}
