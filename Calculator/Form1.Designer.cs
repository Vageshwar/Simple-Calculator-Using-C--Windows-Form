namespace Calculator
{
    partial class calculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.answerText = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.calBtn = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerText
            // 
            this.answerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerText.Location = new System.Drawing.Point(70, 12);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(424, 45);
            this.answerText.TabIndex = 0;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(70, 96);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(107, 55);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(231, 96);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(107, 55);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.button2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(387, 96);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(107, 55);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(387, 170);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(107, 55);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(231, 170);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(107, 55);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(70, 170);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(107, 55);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(387, 243);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(107, 55);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(231, 243);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(107, 55);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(70, 243);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(107, 55);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(387, 316);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(107, 55);
            this.calBtn.TabIndex = 12;
            this.calBtn.Text = "Answer";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(231, 316);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(107, 55);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(70, 316);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(107, 55);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "<----";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(514, 96);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(59, 55);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(514, 168);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(59, 58);
            this.subBtn.TabIndex = 14;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(514, 246);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(55, 52);
            this.mulBtn.TabIndex = 15;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(514, 316);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(55, 55);
            this.divBtn.TabIndex = 16;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(514, 12);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(61, 45);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 408);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.answerText);
            this.Name = "calculatorForm";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button clear;
    }
}

