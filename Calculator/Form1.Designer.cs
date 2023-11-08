namespace Calculator
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
            Button btnBS;
            txtResult = new TextBox();
            btnClear = new Button();
            btnClearEntry = new Button();
            btnPM = new Button();
            btnAdd = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btnSub = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btnMult = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btnDiv = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btn0 = new Button();
            btnBS = new Button();
            SuspendLayout();
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBS.Location = new Point(12, 72);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(81, 60);
            btnBS.TabIndex = 0;
            btnBS.Text = "<--";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(12, 32);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(324, 34);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(174, 72);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 60);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(93, 72);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(81, 60);
            btnClearEntry.TabIndex = 3;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPM.Location = new Point(255, 72);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(81, 60);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(255, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 60);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += numberOP;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(93, 138);
            btn8.Name = "btn8";
            btn8.Size = new Size(81, 60);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(174, 138);
            btn9.Name = "btn9";
            btn9.Size = new Size(81, 60);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 138);
            btn7.Name = "btn7";
            btn7.Size = new Size(81, 60);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(255, 204);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(81, 60);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += numberOP;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(93, 204);
            btn5.Name = "btn5";
            btn5.Size = new Size(81, 60);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(174, 204);
            btn6.Name = "btn6";
            btn6.Size = new Size(81, 60);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 204);
            btn4.Name = "btn4";
            btn4.Size = new Size(81, 60);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(255, 270);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(81, 60);
            btnMult.TabIndex = 16;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberOP;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(93, 270);
            btn2.Name = "btn2";
            btn2.Size = new Size(81, 60);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(174, 270);
            btn3.Name = "btn3";
            btn3.Size = new Size(81, 60);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 270);
            btn1.Name = "btn1";
            btn1.Size = new Size(81, 60);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(255, 336);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(81, 60);
            btnDiv.TabIndex = 20;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOP;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(93, 336);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(81, 60);
            btnDot.TabIndex = 19;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(174, 336);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(81, 60);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += EqualsClick;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 336);
            btn0.Name = "btn0";
            btn0.Size = new Size(81, 60);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDiv);
            Controls.Add(btnDot);
            Controls.Add(btnEqual);
            Controls.Add(btn0);
            Controls.Add(btnMult);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btnSub);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnClearEntry);
            Controls.Add(btnClear);
            Controls.Add(txtResult);
            Controls.Add(btnBS);
            Name = "Form1";
            Text = "1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBS;
        private TextBox txtResult;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnPM;
        private Button btnAdd;
        private Button btn8;
        private Button btn9;
        private Button btn7;
        private Button btnSub;
        private Button btn5;
        private Button btn6;
        private Button btn4;
        private Button btnMult;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btnDiv;
        private Button btnDot;
        private Button btnEqual;
        private Button btn0;
    }
}