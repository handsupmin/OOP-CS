using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_11
{
    // enum 자료형(열거자) {} 안의 내용이 0, 1, 2, 3이 됨
    enum OrderState { Ordered, Paymented, Prepared, Sended };

    public partial class Form1 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // 열거자 사용 예시
        static OrderState OrderCheck(int orderId)
        {
            if (orderId == 12345)
                return OrderState.Ordered;
            else
                return OrderState.Prepared;
        }

        private void button1_Click(object sender, EventArgs e)
        {   /*
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");

            DialogResult result;
            do // 적어도 한 번은 실행하게 만들고자 do while 반복문 사용
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
            */

            CustomForm customForm = new CustomForm();
            // customForm.Show(); // Modeless(모달리스) 대화상자
            // Modeless : 새로운 화면이 열려도 기존에 있던 화면을 조작할 수 있는 형태(MDI)
            customForm.ShowDialog(); // Modal(모달) 대화상자
            // Modal : MDI를 지원하지 않음
        }
    }
}
