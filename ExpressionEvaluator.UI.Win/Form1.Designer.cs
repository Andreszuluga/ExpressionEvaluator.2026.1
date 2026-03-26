namespace ExpressionEvaluator.UI.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnMultiply = new Button();
            btnDelete = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnClear = new Button();
            btnPlus = new Button();
            btnCloseParenthesis = new Button();
            btnPow = new Button();
            btnOpenParenthesis = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Lime;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(644, 34);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.Location = new Point(12, 52);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 94);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.Location = new Point(212, 52);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 94);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.Location = new Point(112, 52);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 94);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.Location = new Point(112, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 94);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button4_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.Location = new Point(212, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 94);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.Location = new Point(12, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 94);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(112, 252);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 94);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(212, 252);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 94);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(12, 252);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 94);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 18F);
            btnDot.Location = new Point(212, 352);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(94, 94);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(12, 352);
            btn0.Name = "btn0";
            btn0.Size = new Size(194, 94);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F);
            btnMultiply.Location = new Point(414, 52);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(94, 94);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F);
            btnDelete.Location = new Point(514, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 94);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.Location = new Point(314, 52);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(94, 94);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F);
            btnMinus.Location = new Point(414, 152);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 94);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(514, 152);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 94);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F);
            btnPlus.Location = new Point(314, 152);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 94);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F);
            btnCloseParenthesis.Location = new Point(414, 252);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(94, 94);
            btnCloseParenthesis.TabIndex = 20;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F);
            btnPow.Location = new Point(514, 252);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(148, 94);
            btnPow.TabIndex = 19;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F);
            btnOpenParenthesis.Location = new Point(314, 252);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(94, 94);
            btnOpenParenthesis.TabIndex = 18;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(255, 128, 0);
            btnEqual.Font = new Font("Segoe UI", 18F);
            btnEqual.Location = new Point(314, 352);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(348, 94);
            btnEqual.TabIndex = 21;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(668, 456);
            Controls.Add(btnEqual);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnPow);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnClear);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDelete);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btn5;
        private Button btn6;
        private Button btn4;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btnDot;
        private Button btn0;
        private Button btnMultiply;
        private Button btnDelete;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnClear;
        private Button btnPlus;
        private Button btnCloseParenthesis;
        private Button btnPow;
        private Button btnOpenParenthesis;
        private Button btnEqual;
    }
}
