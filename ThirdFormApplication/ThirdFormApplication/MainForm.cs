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
        const double inf = -9999999999;
        double result;
        double temp1, temp2;
        int op;
        public MainForm()
        {
            InitializeComponent();
            resetPrmt();
        }

        void resetPrmt()
        {
            result = 0;
            temp1 = inf;
            temp2 = inf;
            op = 0;
            textBoxNumber.Text = "0";
            textBoxOperator.Text = "";
        }

        //textBoxNumber.Text = Convert.ToDouble(textBoxNumber.Text + "2").ToString();

        private void buttonCE_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case 0:
                    return;
                case 1:
                    textBoxNumber.Text = "0";
                    break;
                case 2:
                    textBoxOperator.Text = "";
                    break;
                case 3:
                    textBoxNumber.Text = "0";
                    textBoxOperator.Text = "";
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            resetPrmt();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
                return;
            textBoxNumber.Text = textBoxNumber.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "1";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "2";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "3";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "4";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "5";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "6";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "7";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "8";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxNumber.Clear();
            else if (op == 3)
            {
                textBoxNumber.Clear();
                textBoxOperator.Clear();
            }

            op = 1;
            if (textBoxNumber.Text == "0")
            {
                textBoxNumber.Text = "9";
                return;
            }
            textBoxNumber.Text = textBoxNumber.Text + "9";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (op == 2) { 
                textBoxNumber.Clear();
                textBoxNumber.Text = "0";
            }
            op = 1;
            textBoxNumber.Text = textBoxNumber.Text + ".";
        }

        void Plus()
        {
            temp2 = Convert.ToDouble(textBoxNumber.Text);
            result = temp1 + temp2;
            temp1 = result;
            temp2 = inf;
        }

        void Subtract()
        {
            temp2 = Convert.ToDouble(textBoxNumber.Text);
            result = temp1 - temp2;
            temp1 = result;
            temp2 = inf;
        }

        void Multiple()
        {
            temp2 = Convert.ToDouble(textBoxNumber.Text);
            result = temp1 * temp2;
            temp1 = result;
            temp2 = inf;
        }

        void Division()
        {
            temp2 = Convert.ToDouble(textBoxNumber.Text);
            result = temp1 / temp2;
            temp1 = result;
            temp2 = inf;
        }

        void Equal()
        {
            if (textBoxOperator.Text == "")
                return;
            else if (textBoxOperator.Text == "+")
                Plus();
            else if (textBoxOperator.Text == "-")
                Subtract();
            else if (textBoxOperator.Text == "*")
                Multiple();
            else if (textBoxOperator.Text == "/")
                Division();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(op == 2 && temp2 == inf)
            {
                textBoxOperator.Text = "+";
                return;
            }
            op = 2;
            if (temp1 == inf)
            {
                textBoxOperator.Text = "+";
                temp1 = Convert.ToDouble(textBoxNumber.Text);
            }
            else if (temp2 == inf)
            {
                Equal();
                textBoxNumber.Text = temp1.ToString();
                textBoxOperator.Text = "+";
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (op == 2 && temp2 == inf)
            {
                textBoxOperator.Text = "-";
                return;
            }
            op = 2;
            if (temp1 == inf)
            {
                textBoxOperator.Text = "-";
                temp1 = Convert.ToDouble(textBoxNumber.Text);
            }
            else if (temp2 == inf)
            {
                Equal();
                textBoxNumber.Text = temp1.ToString();
                textBoxOperator.Text = "-";
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (op == 2 && temp2 == inf)
            {
                textBoxOperator.Text = "*";
                return;
            }
            op = 2;
            if (temp1 == inf)
            {
                textBoxOperator.Text = "*";
                temp1 = Convert.ToDouble(textBoxNumber.Text);
            }
            else if (temp2 == inf)
            {
                Equal();
                textBoxNumber.Text = temp1.ToString();
                textBoxOperator.Text = "*";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (op == 2 && temp2 == inf)
            {
                textBoxOperator.Text = "/";
                return;
            }
            op = 2;
            if (temp1 == inf)
            {
                textBoxOperator.Text = "/";
                temp1 = Convert.ToDouble(textBoxNumber.Text);
            }
            else if (temp2 == inf)
            {
                Equal();
                textBoxNumber.Text = temp1.ToString();
                textBoxOperator.Text = "/";
            }
        }

        private void buttonDenominator_Click(object sender, EventArgs e)
        {
            if (op == 2)
                textBoxOperator.Text = "1/x";
            op = 2;
            textBoxOperator.Text = "1/x";
            if (textBoxNumber.Text == "0")
            {
                MessageBox.Show("0은 분모가 될 수 없습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                result = 1 / Convert.ToDouble(textBoxNumber.Text);
                textBoxNumber.Text = result.ToString();
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            op = 3;
            if(textBoxOperator.Text == "")
            {
                textBoxOperator.Text = "=";
                return;
            }
            Equal();

            textBoxOperator.Text = "=";
            textBoxNumber.Text = result.ToString();
            temp1 = inf;
            temp2 = inf;
        }


    }
}
