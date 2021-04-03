
namespace FourthFormApplication
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxBit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEx2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEx16 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEx10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRe10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRe16 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRe2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "원래 수";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(90, 26);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 21);
            this.textBoxNumber.TabIndex = 1;
            // 
            // textBoxBit
            // 
            this.textBoxBit.Location = new System.Drawing.Point(271, 26);
            this.textBoxBit.Name = "textBoxBit";
            this.textBoxBit.Size = new System.Drawing.Size(100, 21);
            this.textBoxBit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "몇 비트";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(413, 24);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "<<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(413, 64);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxEx10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEx16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEx2);
            this.groupBox1.Location = new System.Drawing.Point(41, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "원래 수";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxRe10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxRe16);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxRe2);
            this.groupBox2.Location = new System.Drawing.Point(281, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 149);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.Location = new System.Drawing.Point(65, 33);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.ReadOnly = true;
            this.textBoxEx2.Size = new System.Drawing.Size(100, 21);
            this.textBoxEx2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "이진수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "16진수";
            // 
            // textBoxEx16
            // 
            this.textBoxEx16.Location = new System.Drawing.Point(65, 69);
            this.textBoxEx16.Name = "textBoxEx16";
            this.textBoxEx16.ReadOnly = true;
            this.textBoxEx16.Size = new System.Drawing.Size(100, 21);
            this.textBoxEx16.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "십진수";
            // 
            // textBoxEx10
            // 
            this.textBoxEx10.Location = new System.Drawing.Point(65, 105);
            this.textBoxEx10.Name = "textBoxEx10";
            this.textBoxEx10.ReadOnly = true;
            this.textBoxEx10.Size = new System.Drawing.Size(100, 21);
            this.textBoxEx10.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "십진수";
            // 
            // textBoxRe10
            // 
            this.textBoxRe10.Location = new System.Drawing.Point(61, 105);
            this.textBoxRe10.Name = "textBoxRe10";
            this.textBoxRe10.ReadOnly = true;
            this.textBoxRe10.Size = new System.Drawing.Size(100, 21);
            this.textBoxRe10.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "16진수";
            // 
            // textBoxRe16
            // 
            this.textBoxRe16.Location = new System.Drawing.Point(61, 69);
            this.textBoxRe16.Name = "textBoxRe16";
            this.textBoxRe16.ReadOnly = true;
            this.textBoxRe16.Size = new System.Drawing.Size(100, 21);
            this.textBoxRe16.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "이진수";
            // 
            // textBoxRe2
            // 
            this.textBoxRe2.Location = new System.Drawing.Point(61, 33);
            this.textBoxRe2.Name = "textBoxRe2";
            this.textBoxRe2.ReadOnly = true;
            this.textBoxRe2.Size = new System.Drawing.Size(100, 21);
            this.textBoxRe2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.textBoxBit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shift";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxBit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEx10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEx16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEx2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRe10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRe16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRe2;
    }
}

