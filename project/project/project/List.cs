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
    public partial class List : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "csharp";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";

        public List()
        {
            InitializeComponent();
        }

        public List(string _ID, string _ID_info)
        {
            InitializeComponent();

            label1.Text = _ID + "님의 구매내역";

            try
            {
                _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
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
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM {0}",_ID_info);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        ListViewItem item_temp = new ListViewItem();

                        item_temp.SubItems.Add(table["p_name"].ToString());
                        item_temp.SubItems.Add(table["number"].ToString());
                        item_temp.SubItems.Add(table["price"].ToString()+"원");

                        listView1.Items.Add(item_temp);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            

        }
    }
}
