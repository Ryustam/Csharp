using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(10);

            int user = int.Parse(textBox1.Text);

            if (user == num)
            {
                MessageBox.Show($"컴퓨터:{num},유저:{user} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴퓨터:{num},유저:{user} 틀렸습니다.");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            int age = int.Parse(textBox3.Text);
            string sexual = textBox2.Text;

            int year = DateTime.Now.Year - age + 1;

            MessageBox.Show($"이름:{name} , 나이:{age} , 성별:{sexual}" + "\n" + $"출생년도:{year}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            do
            {
                int mynum = random.Next(45) + 1;

                if (!list.Contains(mynum))
                {
                    list.Add(mynum);
                    
                }


            } while (list.Count() != 6);

            list.Sort();


            Label[] labels = new Label[] {label1,label2,label3,label4,label5,label6,label7};
            
            label1.Text = list[0].ToString();
            label2.Text = list[1].ToString(); 
            label3.Text = list[2].ToString();
            label4.Text = list[3].ToString();        
            label5.Text = list[4].ToString();           
            label6.Text = list[5].ToString();

            do
            {
                int mynum = random.Next(45) + 1;

                if (!list.Contains(mynum))
                {
                    list.Add(mynum);

                }
            } while (list.Count() != 7);

            label7.Text = list[6].ToString();


            
            for (int i = 0; i < labels.Length; i++)
            {
                switch ( (int) int.Parse(labels[i].Text) / 10)
                {
                    case 0:
                        labels[i].ForeColor = Color.Yellow;
                        break;
                    case 1:
                        labels[i].ForeColor = Color.Blue;
                        break;
                    case 2:
                        labels[i].ForeColor = Color.Red;
                        break;
                    case 3:
                        labels[i].ForeColor = Color.Black;
                        break;
                    case 4:
                        labels[i].ForeColor = Color.Green;
                        break;
                    default:
                        break;
                }
            }
          


        }


        private void button14_Click(object sender, EventArgs e)
        {
            string input = textBox5.Text;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random random=new Random();

            int num = random.Next(10)+1;
            int button = 1;
            if(num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 2;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 3;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 4;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 5;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 6;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 7;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 8;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 9;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int num = random.Next(10) + 1;
            int button = 10;
            if (num == button)
            {
                MessageBox.Show($"컴:{num} 정답입니다.");
            }
            else
            {
                MessageBox.Show($"컴:{num} 틀렸습니다.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
