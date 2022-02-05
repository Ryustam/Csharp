using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_answer
{
    public partial class Form1 : Form
    {
        public static string myMessage; //하나의 클래스 모두 공통적으로 쓰는거

        //앞에 public 같은 게 없으므로 private이 적용되어 있다.
        int answer;  //Form1 객체별로 answer 값이 다를 수도 있다.  (=멤버변수


        Label[] labels;

        public Form1()

        {
            InitializeComponent();
            answer = new Random().Next(10) + 1;  //form 뛰우자마자 answer값을 정함 (1~10 중 하나)

            //Controls 는 form 창 안에 있는 모든 것들
            //textBox, button 등이 담겨 잇다.

            //labels = new Label[7];
            //labels[0] = Label1;

            labels = new Label[] { label1, label2, label3, label4, label5, label6, label7 };

            foreach(Label i in labels)
            {
                i.Text = "";
            }


            foreach (var item in Controls)//모든 컴포넌트들을 하나씩 읽어들임
            {
                //textBox 등이 있을 텐데 그 중에서 Button을 만나게 되면!
                if(item is Button) // Controls에 있는 ㅣ것이 버튼일 경우!
                {
                    if ((item as Button).Name.Contains("btn_answer")) //item 자체는 var 이므로, as 키워드로 Button으로 형변환 후
                        //그것의 name값에 btn_answer가 포함되면 click 이벤트를 추가하는 것
                        (item as Button).Click += Answer_Button_Click;
                }
            }

        }

        private void Answer_Button_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //sender : 이벤트를 발생시키는 주체
            //sender 자체는 Button타입이 아니므로, Button 타입으로 형변환 후, 그것의 text값을 num이라는 int 변수에 넣음
            //참고로 as 키워드가 실패하면(형변환 실패) null값을 반환해줌.
            //즉 sender as  Button은 null값이 될 수도 있음
            //근데 지금 Button들한테만 이벤트를 추가한 것으로 그럴일 없음
            int.TryParse((sender as Button).Text, out int num);
            if (num <= 0)
            {
                MessageBox.Show("");
            }
            if (num == answer)
            {
                MessageBox.Show("정답"+num);
                answer = new Random().Next(10) + 1;
            }
            else
            {
                MessageBox.Show("컴:"+answer+"나"+num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"이름:{txt_name.Text}, 나이:{txt_age.Text}, 성별:{txt_gender.Text}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            myMessage = txt_name.Text + txt_age.Text + txt_gender.Text;
            new Form2(txt_name.Text + txt_age.Text + txt_gender.Text).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new Form2(this).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int.Parse
            //공백이나 글자를 넣으면 프로그램이 튕김
            //int.Parse("") 혹은 int.Parse("aaa")
            /*
            int.TryParse(textBox1.Text, out int value);
            MessageBox.Show($"{DateTime.Now.Year+1-value}");
            */

            //visual studio 2017 전까지는...
            //변수를 미리 선언해야했다.
            //2017부턴 안쪽에서 바로 선언하는게 가능 (out int value)

            int value;
            bool result = int.TryParse(textBox1.Text, out value);
            if (result)
            {
                MessageBox.Show("Test");
            }
            else
            {
                MessageBox.Show("숫자 넣으세요");
            }

            if(int.TryParse(textBox1.Text, out value))
            {
                MessageBox.Show("나이는"+value+"입니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int computerNum = new Random().Next(10) + 1;
            if(int.TryParse(textBox2.Text, out int value))
            {
                if(value == computerNum)
                    MessageBox.Show("정답!"+value);
                else
                    MessageBox.Show("value:"+value+"pc:"+computerNum);
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] lotto = new int[7];

            for (int i = 0; i < lotto.Length; i++)
            {
                Random random = new Random();
                int num = random.Next(45) + 1;
                if (lotto.Contains(num))
                {
                    i--;
                }
                else
                {
                    lotto[i] = num;
                }
             }
            Array.Sort(lotto);
            for(int i =0; i<lotto.Length; i++)
            {
                   labels[i].Text = lotto[i].ToString();
            }
            
            foreach(Label item in labels)
            {
                change(item);
            }
        }

        public void change(Label label)
        {
            label.BackColor = Color.Transparent;
            int.TryParse(label.Text, out int value);
            if (value <= 10)
            {
                label.ForeColor = Color.Yellow;
                label.BackColor = Color.Black;
            }
            else if (value <= 20)
            {
                label.ForeColor = Color.Blue;

            }
            else if (value <= 30)
            {
                label.ForeColor = Color.Red;
            }
            else if (value <= 40)
            {
                label.ForeColor = Color.Black;
            }
        }
    }
}
