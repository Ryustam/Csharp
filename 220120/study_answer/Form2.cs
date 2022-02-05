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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string txt)
        {
            InitializeComponent();
            label1.Text = txt;
            MessageBox.Show(Form1.myMessage);
        }

        public Form2(Form1 f)  //form2 를 띄우를 form1 자체를 넘긴 것
        {
            //txt_name를 form1 디자인에서 public으로 바꿔야함
            InitializeComponent();  //이걸 해야지 label1이 생긴다.
            label1.Text = f.txt_name.Text;
        }
    }
}
