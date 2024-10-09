using System;
using System.Windows.Forms;

namespace NTC_Emulator.Dialogs
{
    public partial class VinDialog : Form
    {
        private double _Vin;
        public double VIN
        {
            get { return _Vin; }
            set { _Vin = value; }
        }
        public VinDialog(double vin)
        {
            InitializeComponent();
            _Vin = vin;
            TextVin.Text = vin.ToString("0.000");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            double vin;

            double.TryParse(TextVin.Text, out vin);
            if(vin < 1.2)
            {
                MessageBox.Show("The VIN cannot be less than 1.2 V.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(vin > 6.0)
            {
                MessageBox.Show("VIN cannot exceed 6.0V.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Vin = vin;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TextVin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == '.'))
            {
                if (e.KeyChar == '.')
                {
                    if ((sender as TextBox).Text.IndexOf('.') > -1)
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            else
                e.Handled = false;
        }
    }
}
