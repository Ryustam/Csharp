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
                    if(car.CarNumber.Trim() != "")
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

                        DataManager.Save(textBox_parkingSpot.Text, textBox_carNumber, textBox_driverName.Text, textBox_phoneNumber.Text);
                    }
                }
                catch (Exception ex)  // 존재하지 않는 주차공간으로 접근한 경우
                {

                    string contents = $"주차공간{textBox_parkingSpot.Text}은(는) 없습니다.";
                    MessageBox.Show(contents);
                }
            }

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

        }
    }
}
