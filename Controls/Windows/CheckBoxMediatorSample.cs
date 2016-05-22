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
    public partial class CheckBoxMediatorSample : Form
    {
        public CheckBoxMediatorSample()
        {
            InitializeComponent();
        }

        private void CheckedChangedWarrior(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                _checkBerserker.Checked = false;
                _checkMage.Checked = false;

                _checkOneHandSword.Checked = true;
                _checkTwoHandSword.Checked = false;
                _checkWand.Checked = false;
            }
        }

        private void CheckedChangedBerserker(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                _checkWarrior.Checked = false;
                _checkMage.Checked = false;

                _checkOneHandSword.Checked = true;
                _checkTwoHandSword.Checked = true;
                _checkWand.Checked = false;
            }
        }

        private void CheckedChangedMage(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                _checkWarrior.Checked = false;
                _checkBerserker.Checked = false;

                _checkOneHandSword.Checked = false;
                _checkTwoHandSword.Checked = false;
                _checkWand.Checked = true;
            }
        }
    }
}
