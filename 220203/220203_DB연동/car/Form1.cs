using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carNumber.Text = DataManager.Cars[0].CarNumber.ToString();
                textBox_driverName.Text = DataManager.Cars[0].DriverName.ToString();
                textBox_phoneNumber.Text = DataManager.Cars[0].PhoneNumber.ToString();
            }
            catch (Exception ex)
            {
                DataManager.PrintLog("초기 데이터가 없습니다.");
                DataManager.PrintLog(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
                //throw;
            }

            dataGridView_parkingManager.DataSource= DataManager.Cars;

        }

        List<ParkingCar> tests = new List<ParkingCar>();

        private void button_parkingAdd_Click(object sender, EventArgs e)
        {
           /*
            ParkingCar temp = new ParkingCar();
            temp.CarNumber = "30고1234";
            temp.ParkingSpot = 1;
            temp.PhoneNumber = "운전을 왜 그렇게 해";
            temp.ParkingTime = new DateTime();
            temp.DriverName = "dd";
            parkingCarBindingSource.Add(temp);
           */

            if(textBox_parkingSpot.Text.Trim() =="")  //주자공간번호를 적지 않은 경우
                MessageBox.Show("주차공간을 입력하세요.");
            else if(textBox_carNumber.Text.Trim() =="") //자동차 번호를 적지 않은 경우
                MessageBox.Show("차량 번호를 입력해주세요.");
            else //주차공간번호랑 차량번호를다 적은 경우
            {
                try
                {
                    //List에서 해당하는조건의 객체를 가져온다.
                    //x는 cars 안에 있는 객체들을 의미



                    //car는 단순히 값 복사 아님
                    //참조변수
                    //즉, single로 값을 찾으면 그 값의 위치를 가져감(주소)
                    //이 말의 의미는...
                    //car의 값이 바뀌면.
                    //Cars에 있는 그 값도 같이 바뀜
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    
                    if (car.CarNumber.Trim() != "")
                    {
                        MessageBox.Show("해당 공간에 이미 차가 있습니다.");
                    }
                    else
                    {
                        //이렇게 값을 바꾸면 car는 참조변수라서, (클래스 이용해서 변수선언하는 건 다 참조 변수) (=인스턴스는 다 참조 변수다.)
                        //car가 바뀌면 Cars안에 있는게 바뀐다.
                        car.CarNumber = textBox_carNumber.Text;
                        car.DriverName = textBox_driverName.Text;
                        car.PhoneNumber = textBox_phoneNumber.Text;
                        car.ParkingTime = DateTime.Now;

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save(textBox_parkingSpot.Text, textBox_carNumber.Text, textBox_driverName.Text, textBox_phoneNumber.Text);

                        string contents = $"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차를 주차했다.";

                        WriteLog(contents);
                    }
                }
                catch (Exception ex)  // 존재하지 않는 주차공간으로 접근한 경우
                {

                    string contents = $"주차공간{textBox_parkingSpot.Text}은(는) 없습니다.";
                    MessageBox.Show(contents);
                }
            }

        }

        private void WriteLog(string contents)
        {
            //이 함수 구현 안되었다는 에러 메세지
            //throw new NotImplementedException();

            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff")}]";
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0,logContents);
        }

        private void button_parkingRemove_Click(object sender, EventArgs e)
        {
            /*
            ParkingCar temp = new ParkingCar();
            temp.CarNumber = "30고1234";
            temp.ParkingSpot = 1;
            temp.PhoneNumber = "운전을 왜 그렇게 해";
            temp.ParkingTime = new DateTime();
            temp.DriverName = "dd";
            tests.Add(temp);

            dataGridView_parkingManager.DataSource = null;
            dataGridView_parkingManager.DataSource = tests;
            */
            if (textBox_parkingSpot.Text.Trim() == "")  //주자공간번호를 적지 않은 경우
                MessageBox.Show("주차공간을 입력하세요.");
            else if (textBox_carNumber.Text.Trim() == "") //자동차 번호를 적지 않은 경우
                MessageBox.Show("차량 번호를 입력해주세요.");
            else //주차공간번호랑 차량번호를다 적은 경우
            {
                try
                {
                    //List에서 해당하는조건의 객체를 가져온다.
                    //x는 cars 안에 있는 객체들을 의미

                    //car는 단순히 값 복사 아님
                    //참조변수
                    //즉, single로 값을 찾으면 그 값의 위치를 가져감(주소)
                    //이 말의 의미는...
                    //car의 값이 바뀌면.
                    //Cars에 있는 그 값도 같이 바뀜
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);

                    if (car.CarNumber.Trim() == "")
                    {
                        MessageBox.Show("해당 공간에 아직 차가 없습니다.");
                    }
                    else
                    {
                        //이렇게 값을 바꾸면 car는 참조변수라서, (클래스 이용해서 변수선언하는 건 다 참조 변수) (=인스턴스는 다 참조 변수다.)
                        //car가 바뀌면 Cars안에 있는게 바뀐다.
                        string oldCar = car.CarNumber; //기존에 있던 차
                        car.CarNumber = "";
                        car.DriverName = "";
                        car.PhoneNumber = "";
                        car.ParkingTime = DateTime.Now;
                        //새로고침
                        dataGridView_parkingManager.DataSource = null;
                        //car 바뀌면 Cars안에 있는 것도 같이 바뀜
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save(textBox_parkingSpot.Text, "", "", "",true); //테이블에서 update

                        string contents = $"주차공간 {textBox_parkingSpot.Text}에 {oldCar}차가 출차했습니다.";

                        WriteLog(contents);
                    }
                }
                catch (Exception ex)  // 존재하지 않는 주차공간으로 접근한 경우
                {

                    string contents = $"주차공간{textBox_parkingSpot.Text}은(는) 없습니다.";
                    MessageBox.Show(contents);
                }
            }


        }

        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;
                textBox_parkingSpot.Text = car.ParkingSpot.ToString();
                textBox_carNumber.Text = car.CarNumber;
                textBox_driverName.Text= car.DriverName;
                textBox_phoneNumber.Text = car.PhoneNumber;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void timer_DisplayNow_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Now.Text =
                "현재 시간 :" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //내가 추가할 주차공간 번호를 적는다.
            //visual studio 2015까지는 이렇게 적어야함.
            //int parkingSpot;
            //int.TryParse(textBox_parkingSpot_lookUp.Text, out parkingSpot);
            int.TryParse(textBox_parkingSpot_lookUp.Text, out int parkingSpot);
            if (parkingSpot <= 0)
            {
                //MessageBox.Show("주차공간번호는 0 이상의 숫자여야 합니다.");
                WriteLog("주차공간번호는 0 이상의 숫자여야 합니다.");
                return;//함수 종료
            }

            DBHelper.selectQuery(parkingSpot); //해당되는 주차공간을 찾는다.

            //해당 공간이 없는 거.
            if(DBHelper.dt.Rows.Count < 1)
            {
                DBHelper.insertQuery(parkingSpot);
                string contents = $"주차공간 {parkingSpot}이/가 추가되었습니다.";
                WriteLog(contents);

                button_AllLookUp.PerformClick(); //전제 조회 버튼을 강제로 눌러서 다시 select *~ 호출
            }
            else
            {
                string contents = "해당 주차 공간은 이미 존재";
                MessageBox.Show("Test");
                WriteLog(contents);
            }


        }

        private void button_AllLookUp_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            dataGridView_parkingManager.DataSource = DataManager.Cars;

        }


        //해당 공간에 뭐가 있는지 메시지 박스 띄우는게 전부임.
        private void button_SelectedLookUp_Click(object sender, EventArgs e)
        {
            try
            {
                //int.Parse를 쓸 경우엔 try catch로 감싸주는 것이 안전하다.
                //그게 싫다면 int.TryParse를 쓰면 된다.
                int parkingSpot = int.Parse(textBox_parkingSpot_lookUp.Text);
                string ParkedCar = lookupParkingSpot(parkingSpot); //해당공간에 주차된 차 찾는 함수
                if(ParkedCar != "")
                {
                    string contents = $"주차공간 {parkingSpot}에 주차되어 있는 차는 {ParkedCar}입니다.";
                    WriteLog(contents);
                }
                else
                {
                    string contents = $"주차공간 {parkingSpot}에 주차되어 있는 차는 없습니다.";
                    WriteLog(contents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private string lookupParkingSpot(int parkingSpot)
        {
            try
            {
                //공간번호를 받는 방법 2가지
                //Single 메소드
                //ParkingCar car = DataManager.Cars.Single((x)=>x.ParkingSpot == parkingSpot);
                //return car.CarNumber;
                //foreach문
                string parkedCarNum = "";
                foreach (var item in DataManager.Cars)
                {
                    if (item.ParkingSpot == parkingSpot)
                        return item.CarNumber;
                }
                return parkedCarNum;
            }
            catch (Exception)
            {
                return "";
                //throw new Exception("차 없음");
            }
            //throw new NotImplementedException();
        }
    }
}
