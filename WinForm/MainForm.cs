using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    class MainForm : Form
    {
        public MainForm()
        {
            this.Visible = true;
        }

        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Hello C#");
            base.OnClick(e);
        }
    }
}
