namespace Controls
{
    partial class LevelUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStr = new System.Windows.Forms.Label();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.buttonStr = new Controls.Customs.CustomButton(
                global::Controls.Properties.Resources.dia_normal
                , global::Controls.Properties.Resources.dia_push
                );
            this.buttonInt = new Controls.Customs.CustomButton(
                global::Controls.Properties.Resources.dia_normal
                , global::Controls.Properties.Resources.dia_push
                );
            this.buttonDex = new Controls.Customs.CustomButton(
                global::Controls.Properties.Resources.dia_normal
                , global::Controls.Properties.Resources.dia_push
                );
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intelligence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dexterity";
            // 
            // labelStr
            // 
            this.labelStr.Location = new System.Drawing.Point(114, 47);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(58, 15);
            this.labelStr.TabIndex = 3;
            this.labelStr.Text = "0";
            this.labelStr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInt
            // 
            this.labelInt.Location = new System.Drawing.Point(112, 119);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(58, 15);
            this.labelInt.TabIndex = 4;
            this.labelInt.Text = "0";
            this.labelInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDex
            // 
            this.labelDex.Location = new System.Drawing.Point(112, 186);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(58, 15);
            this.labelDex.TabIndex = 5;
            this.labelDex.Text = "0";
            this.labelDex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonStr
            // 
            this.buttonStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStr.Image = ((System.Drawing.Image)(resources.GetObject("buttonStr.Image")));
            this.buttonStr.Location = new System.Drawing.Point(205, 31);
            this.buttonStr.Name = "buttonStr";
            this.buttonStr.Size = new System.Drawing.Size(86, 47);
            this.buttonStr.TabIndex = 6;
            this.buttonStr.UseVisualStyleBackColor = true;
            this.buttonStr.Click += new System.EventHandler(this.buttonStr_Click);
            // 
            // buttonInt
            // 
            this.buttonInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInt.Image = ((System.Drawing.Image)(resources.GetObject("buttonInt.Image")));
            this.buttonInt.Location = new System.Drawing.Point(205, 103);
            this.buttonInt.Name = "buttonInt";
            this.buttonInt.Size = new System.Drawing.Size(86, 47);
            this.buttonInt.TabIndex = 7;
            this.buttonInt.UseVisualStyleBackColor = true;
            this.buttonInt.Click += new System.EventHandler(this.buttonInt_Click);
            // 
            // buttonDex
            // 
            this.buttonDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDex.Image = ((System.Drawing.Image)(resources.GetObject("buttonDex.Image")));
            this.buttonDex.Location = new System.Drawing.Point(205, 170);
            this.buttonDex.Name = "buttonDex";
            this.buttonDex.Size = new System.Drawing.Size(86, 47);
            this.buttonDex.TabIndex = 8;
            this.buttonDex.UseVisualStyleBackColor = true;
            this.buttonDex.Click += new System.EventHandler(this.buttonDex_Click);
            // 
            // LevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 253);
            this.Controls.Add(this.buttonDex);
            this.Controls.Add(this.buttonInt);
            this.Controls.Add(this.buttonStr);
            this.Controls.Add(this.labelDex);
            this.Controls.Add(this.labelInt);
            this.Controls.Add(this.labelStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LevelUp";
            this.Text = "LevelUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelDex;

        private Customs.CustomButton buttonStr;
        private Customs.CustomButton buttonInt;
        private Customs.CustomButton buttonDex;
    }
}