using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear();
                
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot = int.Parse(item["ParkingSpot"].ToString());
                    car.CarNumber = item["CarNumber"].ToString();
                    car.DriverName = item["DriverName"].ToString();
                    car.PhoneNumber = item["PhoneNumber"].ToString();
                    car.ParkingTime = item["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["Parkingtime"].ToString());
                    Cars.Add(car);
                }
                
                /*
                //linq 사용
                Cars = (from item in DBHelper.ds.Tables[0].Rows select new ParkingCar()
                        {
                            ParkingSpot = int.Parse(item["ParkingSpot"].ToString()),
                            CarNumber = item["CarNumber"].ToString(),
                            DriverName = item["DriverName"].ToString(),
                            PhoneNumber = item["PhoneNumber"].ToString(),
                            ParkingTime = item["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["Parkingtime"].ToString())
                        }).ToList<ParkingCar>();
                */
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        public static void Save(string parkingSpotText, string carNumberText, string driverNameText, string phoneNumber, bool isRemove = false)
        {
            try
            {
                DBHelper.updateQuery(parkingSpotText, carNumberText, driverNameText, phoneNumber, isRemove);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");

            if (!di.Exists)
            {
                di.Create();
            }

            //끝에 true의 의미
            //이거 없으면 한 텍스트파일에 글을 append하는게 아니고
            //그 때 그 때 새로 만들어버림(=덮어쓴다.)
            //여기서 append는 확장한다 . 이어서 쓴다.

            using (StreamWriter writer = new StreamWriter("ParkingHistory" + "\\" + "ParkingHistory" + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
    
}
