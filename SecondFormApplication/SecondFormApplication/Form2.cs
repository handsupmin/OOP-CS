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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class CustomForm : Form // Form 클래스를 상속받는 CustomForm 클래스
        {
            public CustomForm() // 생성자 작성
            {
                Name = "CustomForm"; // 이름을 CustomForm,
                Text = "세 번째 폼"; // 제목을 세 번째 폼 으로 설정
                this.Size = new Size(524, 451); // 폼 크기 설정

                Button button = new Button(); // 버튼 생성 후
                Controls.Add(button);
                button.Location = new Point(206, 191); // 위치 지정
                button.Text = "세 번째 버튼"; // 버튼의 텍스트 수정
                button.Width = 100;

                button.Click += new EventHandler(button_Click); // 새로만든 버튼에도 생성 이벤트를 추가
            }

            public void button_Click(object sender, EventArgs e)
            {
                MessageBox.Show("더이상 폼을 만들 수 없습니다.", "알림"); // 버튼을 누르면 메세지 박스 생성
            }
        }

        private void button1_Click(object sender, EventArgs e) // "두 번째 버튼" 클릭 시
        {
            CustomForm custom = new CustomForm(); // CustomForm 생성
            custom.Show();
        }

    }
}
