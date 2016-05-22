namespace Controls.Windows
{
    partial class CheckBoxMediatorSample
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
            this._checkWarrior = new System.Windows.Forms.CheckBox();
            this._checkBerserker = new System.Windows.Forms.CheckBox();
            this._checkMage = new System.Windows.Forms.CheckBox();
            this._checkWand = new System.Windows.Forms.CheckBox();
            this._checkTwoHandSword = new System.Windows.Forms.CheckBox();
            this._checkOneHandSword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _checkWarrior
            // 
            this._checkWarrior.AutoSize = true;
            this._checkWarrior.Location = new System.Drawing.Point(13, 13);
            this._checkWarrior.Name = "_checkWarrior";
            this._checkWarrior.Size = new System.Drawing.Size(59, 19);
            this._checkWarrior.TabIndex = 0;
            this._checkWarrior.Text = "전사";
            this._checkWarrior.UseVisualStyleBackColor = true;
            this._checkWarrior.CheckedChanged += new System.EventHandler(this.CheckedChangedWarrior);
            // 
            // _checkBerserker
            // 
            this._checkBerserker.AutoSize = true;
            this._checkBerserker.Location = new System.Drawing.Point(12, 38);
            this._checkBerserker.Name = "_checkBerserker";
            this._checkBerserker.Size = new System.Drawing.Size(74, 19);
            this._checkBerserker.TabIndex = 1;
            this._checkBerserker.Text = "버서커";
            this._checkBerserker.UseVisualStyleBackColor = true;
            this._checkBerserker.CheckedChanged += new System.EventHandler(this.CheckedChangedBerserker);
            // 
            // _checkMage
            // 
            this._checkMage.AutoSize = true;
            this._checkMage.Location = new System.Drawing.Point(13, 63);
            this._checkMage.Name = "_checkMage";
            this._checkMage.Size = new System.Drawing.Size(74, 19);
            this._checkMage.TabIndex = 2;
            this._checkMage.Text = "마법사";
            this._checkMage.UseVisualStyleBackColor = true;
            this._checkMage.CheckedChanged += new System.EventHandler(this.CheckedChangedMage);
            // 
            // _checkWand
            // 
            this._checkWand.AutoSize = true;
            this._checkWand.Enabled = false;
            this._checkWand.Location = new System.Drawing.Point(164, 13);
            this._checkWand.Name = "_checkWand";
            this._checkWand.Size = new System.Drawing.Size(144, 19);
            this._checkWand.TabIndex = 3;
            this._checkWand.Text = "지팡이 착용 여부";
            this._checkWand.UseVisualStyleBackColor = true;
            // 
            // _checkTwoHandSword
            // 
            this._checkTwoHandSword.AutoSize = true;
            this._checkTwoHandSword.Enabled = false;
            this._checkTwoHandSword.Location = new System.Drawing.Point(164, 38);
            this._checkTwoHandSword.Name = "_checkTwoHandSword";
            this._checkTwoHandSword.Size = new System.Drawing.Size(144, 19);
            this._checkTwoHandSword.TabIndex = 4;
            this._checkTwoHandSword.Text = "양손검 착용 여부";
            this._checkTwoHandSword.UseVisualStyleBackColor = true;
            // 
            // _checkOneHandSword
            // 
            this._checkOneHandSword.AutoSize = true;
            this._checkOneHandSword.Enabled = false;
            this._checkOneHandSword.Location = new System.Drawing.Point(164, 63);
            this._checkOneHandSword.Name = "_checkOneHandSword";
            this._checkOneHandSword.Size = new System.Drawing.Size(144, 19);
            this._checkOneHandSword.TabIndex = 5;
            this._checkOneHandSword.Text = "한손검 착용 여부";
            this._checkOneHandSword.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMediatorSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 99);
            this.Controls.Add(this._checkOneHandSword);
            this.Controls.Add(this._checkTwoHandSword);
            this.Controls.Add(this._checkWand);
            this.Controls.Add(this._checkMage);
            this.Controls.Add(this._checkBerserker);
            this.Controls.Add(this._checkWarrior);
            this.Name = "CheckBoxMediatorSample";
            this.Text = "CheckBoxMediatorSample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _checkWarrior;
        private System.Windows.Forms.CheckBox _checkBerserker;
        private System.Windows.Forms.CheckBox _checkMage;
        private System.Windows.Forms.CheckBox _checkWand;
        private System.Windows.Forms.CheckBox _checkTwoHandSword;
        private System.Windows.Forms.CheckBox _checkOneHandSword;
    }
}