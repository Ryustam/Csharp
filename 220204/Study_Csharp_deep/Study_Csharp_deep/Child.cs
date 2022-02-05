using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp_deep
{
    public class Child: Parent
    {
        public new string Id { get; set; } // Parent의 ID를 하이딩 함(감춤)
        public new void Method() //Parent의 Method를 하이딩 함
        {
            System.Windows.Forms.MessageBox.Show("헬로우");
        }
        public override void Method2()
        {
            // base.Method2();  조상 클래스의 Method2를 그냥 호출 함
            System.Windows.Forms.MessageBox.Show("잘가");
        }

    }
}
