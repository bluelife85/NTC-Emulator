using NTC_Emulator.EmulationComponent;
using System;
using System.Windows.Forms;

namespace NTC_Emulator.Dialogs
{
    public partial class ResistorParamDialog : Form
    {
        private Resistor _Resistor;
        public Resistor Resistor
        {
            get { return _Resistor; }
            set { _Resistor = value; }
        }
        public ResistorParamDialog(Resistor resistor)
        {
            InitializeComponent();
            Resistor = resistor;
            TextResistance.Text = Resistor.Resistance.ToString("0.000");
            TextTolerance.Text = Resistor.Tolerance.ToString("0.00");
        }

        private void TextResistance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            double v;
            double.TryParse(TextResistance.Text, out v);
            
            if (v < 1.0)
            {
                MessageBox.Show("Resistance must be greater than 1Ω.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Resistor.Resistance = v;

            double.TryParse(TextTolerance.Text, out v);
            if(v < 0 || v > 100)
            {
                MessageBox.Show("Tolerance requires a percentage (0% to 100%) value.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Resistor.Tolerance = v;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
