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
        CheckBoxMediatorPattern mediator = new CheckBoxMediatorPattern();

        public CheckBoxMediatorSample()
        {
            InitializeComponent();

            mediator.AddClass(_checkWarrior, _checkBerserker, _checkMage);
            mediator.AddWeapon(_checkOneHandSword, _checkTwoHandSword, _checkWand);
        }

        private void CheckedChangedClass(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            mediator.ChangeAction(checkBox);
        }
    }
}
