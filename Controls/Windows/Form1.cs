﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 컨트롤");
        }

        private void ButtonPaint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Capture == true)
            {
                button.Image = Properties.Resources.button_down;
            }
            else
            {
                button.Image = Properties.Resources.button_normal;
            }
        }
    }
}
