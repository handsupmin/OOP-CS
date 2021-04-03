using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourthFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            int number = 0, bit = 0, result = 0;
            // try catch문으로 예외처리
            try { 
                number = Convert.ToInt32(textBoxNumber.Text); // 변경할 숫자는 number 변수에 저장
                bit = Convert.ToInt32(textBoxBit.Text); // 변경할 bit수는 bit 변수에 저장
                result = number << bit; // 연산 결과는 result 변수에 저장 (shift left)
            } catch (Exception)
            { // 예외 발생시 메시지를 띄우고 메소드 리턴
                MessageBox.Show("정확한 숫자를 입력해주세요");
                return; 
            }

            MessageBox.Show(number + "를 " + bit + "bit shift left 합니다.", "확인", MessageBoxButtons.OK);

            textBoxEx10.Text = Convert.ToString(number); // 원래 숫자를 10진수로 변환
            textBoxEx2.Text = Convert.ToString(number, 2); // 원래 숫자를 2진수로 변환
            textBoxEx16.Text = Convert.ToString(number, 16); // 원래 숫자를 16진수로 변환

            textBoxRe10.Text = Convert.ToString(result); // 바뀐 숫자를 10진수로 변환
            textBoxRe2.Text = Convert.ToString(result, 2); // 바뀐 숫자를 2진수로 변환
            textBoxRe16.Text = Convert.ToString(result, 16); // 바뀐 숫자를 16진수로 변환
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            int number = 0, bit = 0, result = 0;

            try
            {
                number = Convert.ToInt32(textBoxNumber.Text); // 변경할 숫자는 number 변수에 저장
                bit = Convert.ToInt32(textBoxBit.Text); // 변경할 bit수는 bit 변수에 저장
                result = number >> bit; // 연산 결과는 result 변수에 저장 (shift right)
            }
            catch (Exception)
            {
                MessageBox.Show("정확한 숫자를 입력해주세요");
                return;
            }

            MessageBox.Show(number + "를 " + bit + "bit shift right 합니다.", "확인", MessageBoxButtons.OK);

            textBoxEx10.Text = Convert.ToString(number);
            textBoxEx2.Text = Convert.ToString(number, 2);
            textBoxEx16.Text = Convert.ToString(number, 16);

            textBoxRe10.Text = Convert.ToString(result);
            textBoxRe2.Text = Convert.ToString(result, 2);
            textBoxRe16.Text = Convert.ToString(result, 16);
        }
    }
}
