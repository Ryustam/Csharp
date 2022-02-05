using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("과연 이건 출력이 될까");
            //윈폼에서도 Console.WriteLine() 나오게 하고 싶으면...
            //일단 'Debug' 상태여야 합니다. 
            //1. ctrl+f5가 아닌 f5로 실행
            //2. 속성 자체를 변경(프로젝트를 마우스 오른쪽 클릭해서 속성 선택해서 진행함
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
