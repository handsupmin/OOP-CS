using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdFormApplication
{
    public partial class MainForm : Form
    {
        /*
         *  계산기 프로그래밍
         *  1. 첫 번째 텍스트 박스에는 숫자가 나타난다.
         *  2. 두 번째 텍스트 박스에는 연산자가 나타난다.
         *  3. 25 + 36 - 17 = 이라는 수식을 입력했을 때, - 를 입력하면 25 + 36이 먼저 수행되어 텍스트 박스에 나타난다
         *  4. 내부적으로 temp1, temp2, result가 있고, temp1, temp2는 일반적으로 사용하지 않을법한 숫자를 상수로 지정하였고 이를 이용하여 초기화 여부를 판별한다.
         *  5. 상수 inf 는 -9999999999로, 이는 temp에 유효한 값이 들어가 있는지를 판단하는데 사용된다.
         *  6. C는 모든 요소를 Claer하고 CE는 마지막에 입력된 요소를 초기화한다. (숫자 or 연산자)
         *  7. 변수 op는 각각 0 : 초기상태, 1 : 숫자 입력상태, 2 : 연산자 입력상태, 3 : 결과 출력상태(= 클릭)을 의미한다.
         *  8. op의 상태를 파악하여 CE를 구현하였다.
         *  9. 반복되는 기능들을 함수로 정의하여 line수를 줄이려고 시도했다.
         *  10. 숫자 버튼을 누르면 textBoxNumber에 string의 형식으로 숫자들이 추가 된다.
         *  11. 연산자(+,-,*,/) 클릭 시 숫자가 입력되어있던 textBoxNumber의 텍스트가 double 자료형으로 temp1에 저장된다.
         *  12. 연산자를 한번 더 누르거나 "=" 버튼을 클릭하면 Calculate함수가 실행된다.
         *  13. Calculate 함수는 현재 textBoxNumber에 나타나있던 숫자가 temp2에 저장되고, temp1과 temp2를 textBoxOperator에 나와있는 연산자에 맞게 연산하여 result에 결과를 저장한다.
         *      그 후 temp1에는 result가 저장되고 temp2는 inf로 초기화한다.
         *  14. 만약 "=" 버튼을 누른 경우라면 temp1도 inf로 초기화한다.
         *  15. '.' 버튼이 두번 이상 사용되면 FormatException를 catch한 후 메시지 박스를 출력하여 경고한 후 textBoxNumber를 0으로 초기화한다.
         */
        const double inf = -987654321987; // 일반적으로 사용하지 않을 것으로 예상되어, 해당 변수가 초기화 되었는지를 판단하기 위한 상수로 사용하기 위해 선언
        double result; // 결과가 저장될 변수
        double temp1, temp2; // 연산되어질 숫자들이 임시로 저장되는 변수 temp1, temp2
        int op; // 마지막으로 수행 된 입력의 종류를 파악하기 위한 변수.
        public MainForm()
        {
            InitializeComponent();
            resetPrmt(); // 생성자 실행 시 변수 초기화
        }

        void resetPrmt() // 변수들을 초기화하는 함수(버튼 'C'의 기능)
        {
            result = 0;
            temp1 = inf;
            temp2 = inf;
            op = 0;
            textBoxNumber.Text = "0";
            textBoxOperator.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        { // 'CE'버튼 클릭 시 마지막에 수행한 연산의 종류를 파악 후 해당 기능 수행
            switch(op)
            {
                case 0: // 실행된 것이 없다
                    return;
                case 1: // 숫자 입력 상태
                    textBoxNumber.Text = "0"; // 숫자 초기화
                    break;
                case 2: // 연산자 입력 상태
                    textBoxOperator.Text = ""; // 연산자 초기화
                    break;
                case 3: // '=' 버튼 클릭 상태(연산 결과 도출 상태)
                    resetPrmt(); // 모든 변수 초기화
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        { // 'C' 버튼 클릭 시
            resetPrmt(); // 모든 변수 초기화
        }

        void number_Click(string number)
        { // 숫자 버튼 클릭 시 실행되는 함수, 해당하는 숫자를 parameter로 받아 수행된다.
            if (op == 2) // 마지막으로 눌러진 버튼이 연산자라면
                textBoxNumber.Clear(); // 원래있던 textBoxNumber의 숫자가 temp1에 저장되었을 것이므로, 텍스트박스를 clear해준다.
            else if (op == 3) // 마지막으로 눌러진 버튼이 '='라면
            {
                textBoxNumber.Clear(); // 새로운 연산을 수행해야하므로 두 텍스트박스의 내용을 clear한다.
                textBoxOperator.Clear();
            }

            op = 1; // 숫자 버튼이 클릭되었으므로 op를 1로 설정해준다.
            if (textBoxNumber.Text == "0") // string type이기 때문에 '0123'과 같은 형태로 나오지 않게 하기 위해 텍스트가 0이면 다른 입력된 숫자로 텍스트를 바꾸어준다.
            {
                textBoxNumber.Text = number;
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + number; // 그 외 상태(즉, 0이 아닌 상태일 때)에는 현재 텍스트의 뒤에 숫자를 붙여준다.
        }

        private void button0_Click(object sender, EventArgs e)
        { // 버튼 0 클릭
            number_Click("0");
        }

        private void button1_Click(object sender, EventArgs e)
        { // 버튼 1 클릭
            number_Click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        { // 버튼 2 클릭
            number_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        { // 버튼 3 클릭
            number_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        { // 버튼 4 클릭
            number_Click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        { // 버튼 5 클릭
            number_Click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        { // 버튼 6 클릭
            number_Click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        { // 버튼 7 클릭
            number_Click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        { // 버튼 9 클릭
            number_Click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        { // 버튼 9 클릭
            number_Click("9");
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        { // 버튼 '.' 클릭 시
            
            if (op == 2) { // 연산자 버튼을 누른 후라면,
                textBoxNumber.Clear(); // 현재 textBoxNumber에 들어있는 텍스트를 clear한 후,
                textBoxNumber.Text = "0"; // 0으로 초기화해준다.
            }
            op = 1; // .은 연산자가 아니라 숫자를 입력하는 과정이기에, op를 1로 설정한다.
            textBoxNumber.Text = textBoxNumber.Text + "."; // 그 후 '.'문자를 뒤에 추가해준다.            
        }

        void Calculate()
        { // 연산을 수행하는 핵심 함수
            if (textBoxOperator.Text == "") // 선택된 연산자가 없다면 함수를 리턴한다.
                return;
            try // 소수점이 두번 이상 사용되었을 경우를 위한 try catch문(예외 처리)
            {
                temp2 = Convert.ToDouble(textBoxNumber.Text); // 현재 textBoxNumber에 나타난 숫자를 temp2에 double 형식으로 저장.
            }
            catch (FormatException e)
            {
                MessageBox.Show("소수점(.)을 두 번 이상 사용하지 마십시오.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 경고 메시지 출력 후
                resetPrmt(); // 모든 변수 초기화
                return;
            }

            try { // 예외 처리를 위한 try catch문 사용
                if (textBoxOperator.Text == "+") // 현재 선택된 연산자의 종류에 맞게 연산 수행 후 result에 저장
                    result = temp1 + temp2;
                else if (textBoxOperator.Text == "-")
                    result = temp1 - temp2;
                else if (textBoxOperator.Text == "*")
                    result = temp1 * temp2;
                else if (textBoxOperator.Text == "/")
                { 
                    if(temp2 == 0) // 0으로 나누려고 할 경우 메시지를 띄워주며 함수 리턴
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    result = temp1 / temp2;
                }
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            temp1 = result; // temp1은 result로 변경
            temp2 = inf; // temp2는 inf로 초기화
        }

        void Operate(string oepr)
        { // 연산자가 클릭되었을 때 호출되는 함수
            if (op == 2 && temp2 == inf) // 연산자를 클릭한 후, 연산자를 바꾸고자 다시 연산자를 클릭했을 때,
            {
                textBoxOperator.Text = oepr; // textBoxOperator의 텍스트만 변경 후 리턴
                return;
            }
            op = 2;
            if (temp1 == inf) // 처음으로 연산자를 클릭했을 때,
            {
                textBoxOperator.Text = oepr; // textBoxOperator의 텍스트를 현재 선택한 연산자로 바꾼 후
                try // 소수점 여러개 사용 방지
                {
                    temp1 = Convert.ToDouble(textBoxNumber.Text); // temp1에 textBoxNumber의 숫자를 넣어준다.
                } catch (FormatException e)
                {
                    MessageBox.Show("소수점(.)을 두 번 이상 사용하지 마십시오.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resetPrmt();
                    return;
                }
            }
            else if (temp2 == inf) // 만약 temp1에 값이 들어가있다면 연산자를 두 번이상 사용한 경우이므로
            {
                Calculate(); // 연산을 수행한 후
                textBoxNumber.Text = temp1.ToString(); // 그 결과(Calculate 함수의 마지막쯤에 temp1 = result 가 있으므로)를 띄워준 후,
                textBoxOperator.Text = oepr; // textBoxOperator의 텍스트를 현재 선택한 연산자로 바꿔줌.
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        { // '+' 버튼 클릭시
            Operate("+");
        }

        private void buttonSub_Click(object sender, EventArgs e)
        { // '-' 버튼 클릭시
            Operate("-");
        }

        private void buttonMul_Click(object sender, EventArgs e)
        { // '*' 버튼 클릭시
            Operate("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        { // '/' 버튼 클릭시
            Operate("/");
        }

        private void buttonDenominator_Click(object sender, EventArgs e)
        { // '1/x' 버튼 클릭시
            if (op != 1) // 숫자가 입력되지 않은 상태라면 리턴
                return;
            op = 3; // 결과까지 보여주므로 3으로 초기화
            if (textBoxNumber.Text == "0") // 만약 숫자가 0이라면
            {
                MessageBox.Show("0은 분모가 될 수 없습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); // 메시지박스만 띄운 후 리턴
                return;
            } else // 0이 아니라면
            {
                textBoxOperator.Text = "1/x"; // textBoxOperator의 텍스트를 변경한 후
                result = 1 / Convert.ToDouble(textBoxNumber.Text); // 1/x 연산 수행 후
                textBoxNumber.Text = result.ToString(); // 결과를 보여줌.
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        { // '=' 버튼 클릭 시
            op = 3; // op를 3으로 초기화 한 후
            if(textBoxOperator.Text == "") // 아무 연산자가 선택되지 않은 상태라면
            { // textBoxNumber의 숫자를 그대로 보여주기만 하면 되기에
                textBoxOperator.Text = "="; // textBoxOperator의 텍스트만 '='로 바꿔준 후 함수 리턴
                return;
            }
            Calculate(); // 정상적으로 넘어왔다면 연산 수행

            textBoxOperator.Text = "=";
            textBoxNumber.Text = result.ToString();
            temp1 = inf; // 새로운 계산을 수행하고자 하는 경우를 가정해 temp1도 inf로 초기화해준다.
            temp2 = inf;
        }
    }
}
