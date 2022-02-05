using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp_data_gridview
{
    public partial class Form1 : Form
    {
        List<customer> customerList = new List<customer>();

        public Form1()
        {
            InitializeComponent();
            dataGridView2.Columns.Add("customerName", "고객이름");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
            dataGridView2.Rows.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.name = textBox3.Text;
            customer.id = textBox4.Text;
            customerList.Add(customer);


            //DataSource = 데이터그리드뷰에 집어넣을 데이터, 데이터의 원천.
            dataGridView3.DataSource = null; //null 해줘야 DataSource 교체가 원활하게 일어난다.
            if (customerList.Count > 0) //customerList에 아무것도 없는 데, 이걸 DataSource로 지정하면 에러남
                dataGridView3.DataSource = customerList; // 데이터 그리뷰를 리스트에 있는 데이터로 채워넣음
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string url = "http://apis.data.go.kr/1471000/DURPrdlstInfoService01/";
            string menu = "getUsjntTabooInfoList";
            string serviceKey = "aV5z4gaVInjl4oMwXc5X20tED%2Br0%2F%2Frp7SfYiaMF1xqseghoxLqB0PcK3M%2F7tuBsX8wPceMNALk6fhEPv5XU2g%3D%3D";
            string option = "numOfRows=100";

            url = $"{url}{menu}?ServiceKey={serviceKey}&{option}";
            XElement element = XElement.Load(url);
            List<Drug> Drugs = new List<Drug>();
            foreach (var item in element.Descendants("item"))
            {
                string name = item.Element("ITEM_NAME").Value;
                string id = item.Element("ITEM_SEQ").Value;
                string comp = item.Element("ENTP_NAME").Value;
                Drugs.Add(new Drug(name, id, comp));
            }
            dataGridView4.DataSource = null;
                if(Drugs.Count > 0)
                    dataGridView4.DataSource= Drugs;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 990; //990회차부터 최신회차까지 받는다고 가정.
            List<Lotto> lottos = new List<Lotto>();
            while (true)  //990회차부터 가장 최신 회차까지 다 받는거
            {
                var json = new WebClient().DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count);
                count++;
                var jArray = JObject.Parse(json); //json 객체 받아오기
                if (jArray["returnValue"].ToString() == "fail")
                    break;
                lottos.Add(new Lotto(jArray["drwtNo1"].ToString(),
                    jArray["drwtNo2"].ToString(),
                    jArray["drwtNo3"].ToString(),
                    jArray["drwtNo4"].ToString(),
                    jArray["drwtNo5"].ToString(),
                    jArray["drwtNo6"].ToString(),
                    jArray["bnusNo"].ToString(),
                    jArray["drwNo"].ToString(),
                    jArray["drwNoDate"].ToString()
                    ));
            }
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = lottos;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Name = "출석율";
            chart1.Series[0].Points.AddXY(-1, 0);
            chart1.Series[0].Points.AddXY(1, 10);
            chart1.Series[0].Points.AddXY(2, 20);
            chart1.Series[0].Points.AddXY(3, 30);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Series1 이라는 축은 가지고 있다.
            chart2.Series[0].Name = "기본축";
            chart2.Series[0].Points.AddXY(0.0, 10);
            chart2.Series[0].Points.Add(new double[] {2.0});
            chart2.Series[0].Points.Add(new double[] {5.0});

            chart2.Series.Add("새로운축");
            chart2.Series[1].Points.Add(new double[] { 20.0 });
            chart2.Series[1].Points.Add(new double[] { 55.0 });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            for (int i = 0; i < 10; i++)
                chart3.Series["Series1"].Points.AddXY(i, i + 10);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
