using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 두 번째 폼을 메뉴를 이용하여 생성
        private void 두번째폼열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); // Form2 생성
            form.Show(); // 화면에 띄워줌
        }

        // 폼 제거를 누르면 호출되는 이벤트 함수
        private void 폼제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CustomForm"] != null) // CustomForm이 열려있다면
            {
                Application.OpenForms["CustomForm"].Close(); // CustomForm을 먼저 닫음
                return; // 함수 종료
            } else if(Application.OpenForms["Form2"] != null) // Form2가 열려있다면
            {
                Application.OpenForms["Form2"].Close(); // Form2를 닫음
            } // Form2나 CustomForm이 없다면 아무일도 일어나지 않음
        }
    }
}
