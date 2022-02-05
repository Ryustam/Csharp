using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_data_gridview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qstr = textBox1.Text;
            List<Locale> mls = KakaoAPI.Search(qstr);
            listBox1.Items.Clear();
            foreach(Locale item in mls)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
