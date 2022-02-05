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
    public partial class form : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "csharp";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";

        public form()
        {
            InitializeComponent();
            try
            {
                _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox2.Text);
            Console.WriteLine(textBox3.Text);
            Console.WriteLine(textBox1.Text);

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                               
                    string selectQuery = string.Format("insert into login_info values('{0}',{1},'{2}')",textBox2.Text,textBox3.Text,textBox1.Text);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    MessageBox.Show("성공!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery1 = string.Format("create table {0}(p_name varchar(20),price int,number int)",textBox2.Text);
                    
                    MySqlCommand command1 = new MySqlCommand(selectQuery1, mysql);
                    if (command1.ExecuteNonQuery() != 1)
                        MessageBox.Show("DB 생성완료");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            Dispose();
        }
    }
}
