using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220203_DB연동
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection();


        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectDB()
        {
            conn.ConnectionString = String.Format("Data Source=({0});" + "initial Catalog = {1};" + "Integrated Security={2};" +
                "Timeout=3;",
                "local", "MYDB1", "SSPI"); 
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        private void Query_Select()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM TB_CUST";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); 
            da.Fill(ds,"TB_CUST");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TB_CUST";


            conn.Close();
        }

        private void Query_insert()
        {
            //기본키가 중복될 수 있으니, try catch로 묶는다.
            try
            {
                ConnectDB();

                string sqlcommand = "Insert into TB_CUST (CUST_ID,BIRTH_DT) values(@param1,@p2)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection= conn;
                cmd.CommandType=CommandType.Text;

                cmd.Parameters.AddWithValue("@param1",textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();  


                conn.Close();
            }
            catch (Exception ex)
            {
                //Environment.NewLine
                //\n이랑 똑같은거
                //os 마다 개행문자가 다른데, 그걸 자동으로 맞춰주는 것으로 보면 됨
                //오류는 어떤 것이고, 어디에서 났는지 메세지창 띄움
                //여기선 닫기 누른다고 프로그램이 꺼지진 않음
                conn.Close(); //db연결은 닫아줘야 함
                MessageBox.Show(ex.Message+Environment.NewLine+ex.StackTrace);
                //throw; 

                //throw로 에러메세지 창 띄우면 여기서 '닫기' 누르면 프로그램이 바로 꺼짐
            }
        }

        private void Query_delete()
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0]; //선택된 Row 값 가져옴.
            string data = row.Cells[0].Value.ToString();
            try
            {
                ConnectDB();

                string sqlcommand = "delete from TB_CUST where CUST_ID=@param1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@param1", data);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {    
                conn.Close(); //db연결은 닫아줘야 함
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void Query_update()
        {
            try
            {
                ConnectDB();

                string sqlcommand = "update TB_CUST set BIRTH_DT=@p2 where CUST_ID=@param1";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@param1", textBox1.Text);

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close(); //db연결은 닫아줘야 함
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query_Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query_insert();
            Query_Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query_delete();
            Query_Select();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Query_update();
            Query_Select();
        }
    }
}
