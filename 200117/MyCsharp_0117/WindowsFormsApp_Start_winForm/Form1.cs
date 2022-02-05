using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Start_winForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mbox
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 
            MessageBox.Show("Button2 클릭함");

            Random rnd = new Random();
            int mynum = rnd.Next(10); //0부터 9까지의 값을 줌
            textBox1.Text=mynum.ToString(); 

            int number = int.Parse(textBox1.Text); //textbox에 있는 글자를 숫자로 바꿔줌

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"textBox1의 값은 {textBox1.Text}입니다.");
        }
    }
}
