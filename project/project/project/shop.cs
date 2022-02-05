using MySql.Data.MySqlClient;
using project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace project
{
    public partial class shop : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "csharp";
        string _id = "root";
        string _pw = "1234";
        string _connectionAddress = "";

        private List<productDTO> product_dtos = new List<productDTO>();

        int total =0;

        string _ID;
        string _ID_info;


        int this_page=0;
        int max_page;

        public shop()
        {
            InitializeComponent();
        }

        public shop(login loginForm, string ID, string ID_info)  //form2 를 띄우를 form1 자체를 넘긴 것
        {
            //txt_name를 form1 디자인에서 public으로 바꿔야함
            InitializeComponent();  //이걸 해야지 label1이 생긴다.

            _ID = ID;
            _ID_info = ID_info;

            customer.Text = ID + "님";

            try
            {
                _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


            product_dtos = new List<productDTO>();

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                             
                    string selectQuery = string.Format("SELECT * FROM product limit {0},4", (this_page*4));

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        string name = table["name"].ToString();
                        Console.WriteLine(name);
                        int price = int.Parse(table["price"].ToString());
                        Console.WriteLine(price);
                        productDTO product = new productDTO(name, price);
                        product_dtos.Add(product);
                    }
                    table.Close();
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
                               
                    string selectQuery = string.Format("SELECT count(*) FROM product");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        int count = int.Parse(table["count(*)"].ToString());
                        max_page = (count/4)-1;
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            PictureBox[] images = new PictureBox[] { p_image1, p_image2, p_image3, p_image4 };
            Label[] names = new Label[] { p_name1, p_name2, p_name3, p_name4 };
            Label[] prices = new Label[] { p_price1, p_price2, p_price3, p_price4};
            Label[] numbers = new Label[] { p_number1, p_number2, p_number3, p_number4};

            label6.Text = String.Format("0");


            for (int i = 0; i < product_dtos.Count; i++)
            {
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                string image_path = string.Format("images\\{0}.jpg", product_dtos.ElementAt(i).getName());
                var iconPath = Path.Combine(outPutDirectory, image_path);
                string icon_path = new Uri(iconPath).LocalPath;

                images[i].Image = Image.FromFile(@icon_path);

                names[i].Text= product_dtos.ElementAt(i).getName();
                prices[i].Text = product_dtos.ElementAt(i).getPrice().ToString();
                numbers[i].Text = String.Format("0");
            }
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number1.Text);

            if (number!=0)
            {
                number--;
            }
            p_number1.Text = String.Format(number.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number1.Text);
            number++;
            p_number1.Text = String.Format(number.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DeleteLineChecked_listView(listView1);
            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int price = int.Parse(listView1.Items[i].SubItems[3].Text);
                sum += price;
            }
            total = sum;
            label6.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (p_number1.Text =="0")
            {
                MessageBox.Show("수량을 선택해주세요");
            }
            else
            {
                ListViewItem item_temp = new ListViewItem();

                item_temp.SubItems.Add(p_name1.Text);
                item_temp.SubItems.Add(p_number1.Text);
                item_temp.SubItems.Add((int.Parse(p_price1.Text) *int.Parse(p_number1.Text)).ToString());

                listView1.Items.Add(item_temp);

                p_number1.Text = String.Format("0");
            }


            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int price = int.Parse(listView1.Items[i].SubItems[3].Text);
                sum += price;
            }
            total = sum;
            label6.Text = total.ToString();

        }
        private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if ((e.ColumnIndex == 0))
            {
                CheckBox cck = new CheckBox();
                Text = "";
                listView1.SuspendLayout();  // 컨트롤의 레이아웃 논리를 임시로 일시 중단
                e.DrawBackground();  // 열 머리글의 배경색을 그리기
                cck.BackColor = Color.Transparent;
                cck.UseVisualStyleBackColor = true;  // 비주얼 스타일을 사용하여 배경을 그리면 true

                // 컨트롤의 범위를 지정된 위치와 크기로 설정 (Left x, Top y, width, height)
                cck.SetBounds(e.Bounds.X, e.Bounds.Y, cck.GetPreferredSize(new Size(e.Bounds.Width, e.Bounds.Height)).Width, cck.GetPreferredSize(new Size(e.Bounds.Width, e.Bounds.Height)).Width);

                // 컨트롤의 높이와 너비를 가져오거나 설정

                cck.Size = new Size((cck.GetPreferredSize(new Size((e.Bounds.Width - 1), e.Bounds.Height)).Width + 1), e.Bounds.Height);
                cck.Location = new Point(4, 0); // 왼쪽 위를 기준으로 컨트롤의 왼쪽 위의 좌표를 가져오거나 설정
                listView1.Controls.Add(cck);
                cck.Show();
                //cck.BringToFront();
                Visible = true;  // 컨트롤과 모든 해당 자식 컨트롤이 표시되면 true

                e.DrawText((TextFormatFlags.VerticalCenter | TextFormatFlags.Left));
                cck.Click += new EventHandler(Bink);  // 컨트롤을 클릭하면 발생
                listView1.ResumeLayout(true);  // 일반 레이아웃 논리를 다시 시작

            }
            else
            {
                e.DrawDefault = true;
            }
        }


        // 컬럼헤더에 있는 체크박스 클릭시 나머지 체크박스들도 자동 체크되도록 하는 로직
        private void Bink(object sender, System.EventArgs e)
        {
            CheckBox cck = sender as CheckBox;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = cck.Checked;
            }
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void DeleteLineChecked_listView(ListView LV)
        {
            for (int row = LV.Items.Count - 1; row >= 0; row--)
            {
                if (LV.Items[row].Checked)
                {
                    //LV.Items.Remove(LV.Items[row]);
                    LV.Items.RemoveAt(row);
                }
            }          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number2.Text);

            if (number != 0)
            {
                number--;
            }
            p_number2.Text = String.Format(number.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number2.Text);
            number++;
            p_number2.Text = String.Format(number.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number3.Text);

            if (number != 0)
            {
                number--;
            }
            p_number3.Text = String.Format(number.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number3.Text);
            number++;
            p_number3.Text = String.Format(number.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number4.Text);

            if (number != 0)
            {
                number--;
            }
            p_number4.Text = String.Format(number.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int number = int.Parse(p_number4.Text);
            number++;
            p_number4.Text = String.Format(number.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p_number2.Text == "0")
            {
                MessageBox.Show("수량을 선택해주세요");
            }
            else
            {
                ListViewItem item_temp = new ListViewItem();

                item_temp.SubItems.Add(p_name2.Text);
                item_temp.SubItems.Add(p_number2.Text);
                item_temp.SubItems.Add((int.Parse(p_price2.Text) * int.Parse(p_number2.Text)).ToString());

                listView1.Items.Add(item_temp);

                p_number2.Text = String.Format("0");
            }

            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int price = int.Parse(listView1.Items[i].SubItems[3].Text);
                sum += price;
            }
            total = sum;
            label6.Text = total.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (p_number3.Text == "0")
            {
                MessageBox.Show("수량을 선택해주세요");
            }
            else
            {
                ListViewItem item_temp = new ListViewItem();

                item_temp.SubItems.Add(p_name3.Text);
                item_temp.SubItems.Add(p_number3.Text);
                item_temp.SubItems.Add((int.Parse(p_price3.Text) * int.Parse(p_number3.Text)).ToString());

                listView1.Items.Add(item_temp);

                p_number3.Text = String.Format("0");
            }

            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int price = int.Parse(listView1.Items[i].SubItems[3].Text);
                sum += price;
            }
            total = sum;
            label6.Text = total.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (p_number4.Text == "0")
            {
                MessageBox.Show("수량을 선택해주세요");
            }
            else
            {
                ListViewItem item_temp = new ListViewItem();

                item_temp.SubItems.Add(p_name4.Text);
                item_temp.SubItems.Add(p_number4.Text);
                item_temp.SubItems.Add((int.Parse(p_price4.Text) * int.Parse(p_number4.Text)).ToString());

                listView1.Items.Add(item_temp);

                p_number4.Text = String.Format("0");
            }

            int sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                int price = int.Parse(listView1.Items[i].SubItems[3].Text);
                sum += price;
            }
            total = sum;
            label6.Text = total.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Visible = false;
           login newForm =new login();
            newForm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buy buy = new buy(_ID_info, listView1);
            buy.ShowDialog();
            listView1.Items.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (this_page != 0)
            {
                this_page--;
                loadProduct();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this_page != max_page )
            {
                this_page++;
                loadProduct();
            }
        }

        public void loadProduct()
        {
            product_dtos = new List<productDTO>();

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT * FROM product limit {0},4", this_page*4);

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        string name = table["name"].ToString();
                        Console.WriteLine(name);
                        int price = int.Parse(table["price"].ToString());
                        Console.WriteLine(price);
                        productDTO product = new productDTO(name, price);
                        product_dtos.Add(product);
                    }
                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            PictureBox[] images = new PictureBox[] { p_image1, p_image2, p_image3, p_image4 };
            Label[] names = new Label[] { p_name1, p_name2, p_name3, p_name4 };
            Label[] prices = new Label[] { p_price1, p_price2, p_price3, p_price4 };
            Label[] numbers = new Label[] { p_number1, p_number2, p_number3, p_number4 };

            for (int i = 0; i < product_dtos.Count; i++)
            {
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                string image_path = string.Format("images\\{0}.jpg", product_dtos.ElementAt(i).getName());
                var iconPath = Path.Combine(outPutDirectory, image_path);
                string icon_path = new Uri(iconPath).LocalPath;

                images[i].Image = Image.FromFile(@icon_path);

                names[i].Text = product_dtos.ElementAt(i).getName();
                prices[i].Text = product_dtos.ElementAt(i).getPrice().ToString();
                numbers[i].Text = String.Format("0");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new List(_ID,_ID_info).Show();
        }
    }
}
