namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonAllClear = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.buttonresult = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.explain = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonDot, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 284);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonDivide
            // 
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDivide.Location = new System.Drawing.Point(357, 216);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(112, 65);
            this.buttonDivide.TabIndex = 15;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDot.Location = new System.Drawing.Point(239, 216);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(112, 65);
            this.buttonDot.TabIndex = 14;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // button0
            // 
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button0.Location = new System.Drawing.Point(121, 216);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(112, 65);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonAllClear
            // 
            this.buttonAllClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAllClear.Location = new System.Drawing.Point(3, 216);
            this.buttonAllClear.Name = "buttonAllClear";
            this.buttonAllClear.Size = new System.Drawing.Size(112, 65);
            this.buttonAllClear.TabIndex = 12;
            this.buttonAllClear.Text = "AC";
            this.buttonAllClear.UseVisualStyleBackColor = true;
            this.buttonAllClear.Click += new System.EventHandler(this.buttonAllClear_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMultiply.Location = new System.Drawing.Point(357, 145);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(112, 65);
            this.buttonMultiply.TabIndex = 11;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(239, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 65);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(121, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(3, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMinus.Location = new System.Drawing.Point(357, 74);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(112, 65);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "－";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(239, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(121, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(3, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlus.Location = new System.Drawing.Point(357, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(112, 65);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "＋";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Location = new System.Drawing.Point(239, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 65);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(121, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 65);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_7
            // 
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_7.Location = new System.Drawing.Point(3, 3);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(112, 65);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonresult
            // 
            this.buttonresult.Location = new System.Drawing.Point(6, 346);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(472, 54);
            this.buttonresult.TabIndex = 0;
            this.buttonresult.Text = "=";
            this.buttonresult.Click += new System.EventHandler(this.buttonresult_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display.Location = new System.Drawing.Point(6, 23);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(472, 30);
            this.display.TabIndex = 2;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // explain
            // 
            this.explain.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.explain.Location = new System.Drawing.Point(6, -1);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(472, 24);
            this.explain.TabIndex = 3;
            this.explain.Text = "0";
            this.explain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 412);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.display);
            this.Controls.Add(this.buttonresult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAllClear;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonresult;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label explain;
    }
}

