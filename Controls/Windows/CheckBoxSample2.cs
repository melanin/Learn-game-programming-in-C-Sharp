using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Windows
{
    public partial class CheckBoxSample2 : Form
    {
        public CheckBoxSample2()
        {
            InitializeComponent();
        }

        private void CheckThis(object __sender, EventArgs __event)
        {
            CheckBox checkBox = (CheckBox)__sender;
            _textChecked.Text = checkBox.Checked ? "TRUE" : "FALSE";

            switch (checkBox.CheckState)
            {
                case CheckState.Checked:
                    {
                        _textCheckState.Text = "Checked";
                    }
                    break;

                case CheckState.Unchecked:
                    {
                        _textCheckState.Text = "Unchecked";
                    }
                    break;

                case CheckState.Indeterminate:
                    {
                        _textCheckState.Text = "Indeterminate";
                    }
                    break;
            }
        }

        private void MouseEnter1(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }

        private void MouseEnter2(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }

        private void MouseEnter3(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }

        private void Click1(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }

        private void Click2(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }

        private void Click3(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }
    }
}
