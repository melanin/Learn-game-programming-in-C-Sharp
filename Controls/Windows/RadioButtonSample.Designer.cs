namespace Controls.Windows
{
    partial class RadioButtonSample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this._radioBlack = new System.Windows.Forms.RadioButton();
            this._radioRed = new System.Windows.Forms.RadioButton();
            this._radioGreen = new System.Windows.Forms.RadioButton();
            this._radioBlue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._colorBox = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "차 목록";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "투스카니";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.SelectCar);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "벤츠";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.SelectCar);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "오피러스";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.SelectCar);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 99);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "페라리";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.SelectCar);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 124);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "람보르기니";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.SelectCar);
            // 
            // _radioBlack
            // 
            this._radioBlack.AutoSize = true;
            this._radioBlack.Location = new System.Drawing.Point(15, 34);
            this._radioBlack.Name = "_radioBlack";
            this._radioBlack.Size = new System.Drawing.Size(73, 19);
            this._radioBlack.TabIndex = 1;
            this._radioBlack.TabStop = true;
            this._radioBlack.Text = "검정색";
            this._radioBlack.UseVisualStyleBackColor = true;
            this._radioBlack.Click += new System.EventHandler(this.SelectColor);
            // 
            // _radioRed
            // 
            this._radioRed.AutoSize = true;
            this._radioRed.ForeColor = System.Drawing.Color.Red;
            this._radioRed.Location = new System.Drawing.Point(15, 60);
            this._radioRed.Name = "_radioRed";
            this._radioRed.Size = new System.Drawing.Size(73, 19);
            this._radioRed.TabIndex = 2;
            this._radioRed.TabStop = true;
            this._radioRed.Text = "빨간색";
            this._radioRed.UseVisualStyleBackColor = true;
            this._radioRed.Click += new System.EventHandler(this.SelectColor);
            // 
            // _radioGreen
            // 
            this._radioGreen.AutoSize = true;
            this._radioGreen.ForeColor = System.Drawing.Color.Green;
            this._radioGreen.Location = new System.Drawing.Point(15, 85);
            this._radioGreen.Name = "_radioGreen";
            this._radioGreen.Size = new System.Drawing.Size(73, 19);
            this._radioGreen.TabIndex = 3;
            this._radioGreen.TabStop = true;
            this._radioGreen.Text = "초록색";
            this._radioGreen.UseVisualStyleBackColor = true;
            this._radioGreen.Click += new System.EventHandler(this.SelectColor);
            // 
            // _radioBlue
            // 
            this._radioBlue.AutoSize = true;
            this._radioBlue.ForeColor = System.Drawing.Color.Blue;
            this._radioBlue.Location = new System.Drawing.Point(15, 110);
            this._radioBlue.Name = "_radioBlue";
            this._radioBlue.Size = new System.Drawing.Size(73, 19);
            this._radioBlue.TabIndex = 4;
            this._radioBlue.TabStop = true;
            this._radioBlue.Text = "파란색";
            this._radioBlue.UseVisualStyleBackColor = true;
            this._radioBlue.Click += new System.EventHandler(this.SelectColor);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._radioGreen);
            this.groupBox2.Controls.Add(this._radioBlue);
            this.groupBox2.Controls.Add(this._radioBlack);
            this.groupBox2.Controls.Add(this._radioRed);
            this.groupBox2.Location = new System.Drawing.Point(245, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "색상";
            // 
            // _colorBox
            // 
            this._colorBox.BackColor = System.Drawing.SystemColors.Control;
            this._colorBox.Enabled = false;
            this._colorBox.Location = new System.Drawing.Point(245, 232);
            this._colorBox.Name = "_colorBox";
            this._colorBox.Size = new System.Drawing.Size(109, 36);
            this._colorBox.TabIndex = 6;
            this._colorBox.UseVisualStyleBackColor = false;
            // 
            // RadioButtonSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 360);
            this.Controls.Add(this._colorBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RadioButtonSample";
            this.Text = "RadioButtonSample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton _radioBlack;
        private System.Windows.Forms.RadioButton _radioRed;
        private System.Windows.Forms.RadioButton _radioGreen;
        private System.Windows.Forms.RadioButton _radioBlue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _colorBox;
    }
}