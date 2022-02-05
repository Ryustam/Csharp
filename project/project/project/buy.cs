using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class buy : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "csharp";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";

        string _ID;
        ListView this_listView;

        public buy()
        {
            InitializeComponent();
        }

        public buy(string ID, ListView listView1)
        {
            InitializeComponent();
            this_listView = listView1;
            _ID = ID;

            try
            {
                _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            textBox1.Text = "";
            int total_price = 0;
            string tab = Environment.NewLine;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string item = listView1.Items[i].SubItems[1].Text;
                Console.WriteLine(item.Length);
                item=PadingRight(item,15);
                string number = listView1.Items[i].SubItems[2].Text;
                number=PadingRight(number,3);
                Console.WriteLine(number.Length);
                string price = listView1.Items[i].SubItems[3].Text ;
                price=PadingRight(price,8);
                Console.WriteLine(price.Length);
                total_price += int.Parse(listView1.Items[i].SubItems[3].Text);
                textBox1.Text += item + number + "개" + price + "원" + tab ;
            }
            textBox1.Text += "--------------------------";
            textBox1.Text += tab;
            textBox1.Text += "총금액:"+total_price + "원";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this_listView.Items.Count; i++)
            {
                try
                {
                    using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                    {
                        mysql.Open();
                        //accounts_table의 전체 데이터를 조회합니다.            
                        string selectQuery = string.Format("insert into {0} values('{1}',{2},{3})", _ID, this_listView.Items[i].SubItems[1].Text, 
                            int.Parse(this_listView.Items[i].SubItems[3].Text),int.Parse(this_listView.Items[i].SubItems[2].Text));

                        MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                        

                        if (command.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to delete data.");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            MessageBox.Show("구매가 완료되었습니다.");
            Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public string PadingRight(string str, int num)
        {
            int num2 = num - str.Length;
            str = str.PadRight(num2,' ');
            return str;
        }
    }
}
