using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace project
{

    public partial class login : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "csharp";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";

        private List<loginDTO> login_dtos = new List<loginDTO>();

        public login()
        {
            InitializeComponent();
            try
            {
                _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", 
                _server, _port, _database, _id, _pw);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_dtos = new List<loginDTO>();
            bool temp = false;
            Console.WriteLine(textBox1.Text);
            Console.WriteLine(textBox2.Text);
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM login_info where ID='{0}'",textBox1.Text);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();
                   
                    while(table.Read())
                    {
                       string ID= table["ID"].ToString();
                        Console.WriteLine(ID);
                       string PW = table["PW"].ToString();
                        Console.WriteLine(PW);
                        string name = table["name"].ToString();
                        loginDTO login = new loginDTO(ID,PW,name);
                        login_dtos.Add(login);  
                    }
                    
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


            if (login_dtos !=null)
            {
                if (textBox1.Text.Equals(login_dtos.ElementAt(0).getID())) 
                {
                    if (textBox2.Text.Equals(login_dtos.ElementAt(0).getPW()))
                    {
                        MessageBox.Show("로그인에 성공하였습니다.");
                        new shop(this,login_dtos.ElementAt(0).getName(),login_dtos.ElementAt(0).getID()).Show();
                        Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 틀렸습니다.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("없는 아이디입니다.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new form().Show();
        }
    }
}
