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
    public partial class RadioButtonSample : Form
    {
        public RadioButtonSample()
        {
            InitializeComponent();
        }

        private void SelectColor(object sender, EventArgs e)
        {
            RadioButton color = (RadioButton)sender;

            switch (color.Text)
            {
                case "검정색":
                    {
                        _colorBox.BackColor = Color.Black;
                    }
                    break;

                case "빨간색":
                    {
                        _colorBox.BackColor = Color.Red;
                    }
                    break;

                case "초록색":
                    {
                        _colorBox.BackColor = Color.Green;
                    }
                    break;

                case "파란색":
                    {
                        _colorBox.BackColor = Color.Blue;
                    }
                    break;
            }
        }

        private void SelectCar(object sender, EventArgs e)
        {
            //foreach (Control radios in this.Controls)
            //{
            //    RadioButton radio = radios as RadioButton;
            //    if (null != radio)
            //    {
            //        if (radio.Checked)
            //        {
            //            BuyaCar(radio.Text);
            //        }
            //    }
            //}

            RadioButton car = sender as RadioButton;
            if (null != car)
            {
                BuyaCar(car.Text);
            }
        }

        private void BuyaCar(string __car)
        {
            MessageBox.Show(string.Format("give me the {0}", __car));
        }
    }
}
