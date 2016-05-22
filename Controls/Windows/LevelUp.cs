using System;
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
    public partial class LevelUp : Form
    {
        private int _strength = 0;
        private int _intelligence = 0;
        private int _dexterity = 0;

        public LevelUp()
        {
            InitializeComponent();

            labelStr.Text = _strength.ToString();
            labelInt.Text = _intelligence.ToString();
            labelDex.Text = _dexterity.ToString();
        }

        private void buttonStr_Click(object sender, EventArgs e)
        {
            _strength++;
            labelStr.Text = _strength.ToString();
        }

        private void buttonInt_Click(object sender, EventArgs e)
        {
            _intelligence++;
            labelInt.Text = _intelligence.ToString();
        }

        private void buttonDex_Click(object sender, EventArgs e)
        {
            _dexterity++;
            labelDex.Text = _dexterity.ToString();
        }
    }
}
