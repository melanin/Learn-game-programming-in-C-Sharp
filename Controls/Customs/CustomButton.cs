using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controls.Customs
{
    class CustomButton : Button
    {
        private Bitmap _normal;
        private Bitmap _pushed;

        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Selectable, false);//포커스 삭제

            _normal = new Bitmap(global::Controls.Properties.Resources.button_normal);
            _pushed = new Bitmap(global::Controls.Properties.Resources.button_down);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (Capture && ((MouseButtons & MouseButtons.Left) != 0))
            {
                this.Image = _pushed;
            }
            else
            {
                this.Image = _normal;
            }
        }
    }
}
