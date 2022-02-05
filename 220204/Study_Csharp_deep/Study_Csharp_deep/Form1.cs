using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Csharp_deep
{
    public partial class Form1 : Form
    {
        //상수랑 좀 비슷
        //근데 이 멤버들을 int로 형변환하면...
        //숫자로 바뀜

        enum Rock_Scissor_Paper
        {
            GAWI,BAWI,BO
        }


        public Form1()
        {
            InitializeComponent();

            button_gawi.Click += RSP_Click;
            button_bawi.Click += RSP_Click;
            button_bo.Click += RSP_Click;
        }

        private void RSP_Click(object sender, EventArgs e)
        {
            int pc = new Random().Next(3); // 0,1,2 중 하나 나옴
            int mychoice =0;

            Button b = (sender as Button); //내가 누른 버튼

            string myresult = b.Name.Split('_')[1].ToUpper();

            if (myresult == "GAWI")
                mychoice = 0;
            else if (myresult == "BAWI")
                mychoice = 1;
            else if (myresult == "BO")
                mychoice = 2;

            //숫자 0,1,2를 Rock_Scissor_Paper로 변환 가능
            //Rock_Scissor_Paper의 GAWI, BAWI, BO 역시도 int로 변환이 가능
            //상수처럼 값에 다가 이름을 붙여버림.

            switch ((Rock_Scissor_Paper)mychoice)
            {
                case Rock_Scissor_Paper.GAWI: //0
                    switch (pc)
                    {
                        case (int)Rock_Scissor_Paper.GAWI: //0
                            MessageBox.Show("비김");
                            break;

                        case (int)Rock_Scissor_Paper.BAWI: //1
                            MessageBox.Show("짐");
                            break;

                        case (int)Rock_Scissor_Paper.BO: //2
                            MessageBox.Show("이김");
                            break;

                        default:
                            break;
                    }
                    break;
                case Rock_Scissor_Paper.BAWI:
                    break;
                case Rock_Scissor_Paper.BO:
                    break;
                default:
                    break;
            }
        }



        //a와 b의 값을 바꾼다.
        //하지만 a와 b는 swap_fail 함수가 끝나면 사라진다.

        private void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);  
            swap(a, b);
            MessageBox.Show("a:"+a+"b:"+b);
            
        }


        //swap(int a, int )랑은 매개변수가 다름.
        //지금 이 swap은 a와 b의 참조값을 받아옴.
        private void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private int study_out_keyword (out int a, out int b)
        {
            //out은 반드시 값을 줘야함
            //out은 해당 매개변수에 값을 대입시키는 게 목적

            //ref는 해당 값을 읽어들이는게 목적.
            a = 100;
            b = 200;
            return -1000;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            swap(ref a, ref b);
            MessageBox.Show("a:" + a + "b:" + b);

            int c = 0;
            int d = -1;
            int result = study_out_keyword(out c, out d);
            MessageBox.Show($"result={result},c={c},d={d}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parent p = new Parent();
            p.Id = 1;
            p.Method();
            p.Method2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Child c = new Child();
            c.Id = "일";
            c.Method();
            c.Method2();   

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Child pc =new Child();
            ((Parent)pc).Id = 1;   //parent의 id는 int ,child는 string
            ((Parent)pc).Method(); //하이딩한거
            ((Parent)pc).Method2(); //오버라이딩 된 거

            //오버라이딩 (OverRide)
            //오버라이트
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Parent KDJ = new Parent();
            KDJ.Id = 100;
            Parent LDJ = KDJ;
            LDJ.Id = -456;

            // 이 상을 벗어나고 싶다면 각자 new 키워드 이용해서 인스턴스 따로 만들고
            //.Id 만을 별도로 복사하거나 Clone을 별도로 구현해야 됨

            MessageBox.Show("KDJ의 ID =" + KDJ.Id);
            MessageBox.Show("LDJ의 ID =" + LDJ.Id);
        }
        
        void Increase(Parent P)
        {
            P.Id++;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Parent P = new Parent();
            P.Id = 500;
            Increase(P);
            MessageBox.Show("p.Id"+P.Id);
        }
    }
}
