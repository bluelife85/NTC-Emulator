using NTC_Emulator.EmulationComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTC_Emulator.Dialogs
{
    public partial class NTCParamDialog : Form
    {
        private NTC _NTC;
        private Temperature.Units _Unit;
        public NTC NTC
        {
            get { return _NTC; }
            set { _NTC = value; }
        }
        public Temperature.Units Unit
        {
            set { _Unit = value; }
        }
        public NTCParamDialog(NTC ntc, Temperature.Units unit)
        {
            InitializeComponent();
            _NTC = ntc;
            _Unit = unit;
            TextRTMinRes.Text = _NTC.MinimumRT.Resistance.ToString("0.000");
            TextRTMinTemp.Text = _NTC.MinimumRT.Temperature.GetTemperature(unit).ToString("0.000");
            TextR25Res.Text = _NTC.R25.Resistance.ToString("0.000");
            TextR25Temp.Text = _NTC.R25.Temperature.GetTemperature(unit).ToString("0.000");
            TextRTMaxRes.Text = _NTC.MaximumRT.Resistance.ToString("0.000");
            TextRTMaxTemp.Text = _NTC.MaximumRT.Temperature.GetTemperature(unit).ToString("0.000");
            TextTolerance.Text = _NTC.Tolerance.ToString("0.00");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            double rt_min_res;
            double rt_min_temp;
            double rt_r25_res;
            double rt_r25_temp;
            double rt_max_res;
            double rt_max_temp;
            double tolerance;

            DialogResult = DialogResult.Cancel;

            double.TryParse(TextRTMinRes.Text, out rt_min_res);
            double.TryParse(TextRTMinTemp.Text, out rt_min_temp);
            double.TryParse(TextRTMaxRes.Text, out rt_max_res);
            double.TryParse(TextRTMaxTemp.Text, out rt_max_temp);
            double.TryParse(TextR25Res.Text, out rt_r25_res);
            double.TryParse(TextR25Temp.Text, out rt_r25_temp);
            double.TryParse(TextTolerance.Text, out tolerance);

            if(rt_min_res < rt_r25_res)
            {
                MessageBox.Show("The resistance of RT minimum cannot be less than RT @ room temperature.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(rt_max_res > rt_r25_res)
            {
                MessageBox.Show("The resistance of RT maximum cannot exceed RT @ room temperature.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(rt_min_temp > rt_r25_temp)
            {
                MessageBox.Show("The minimum temperature cannot exceed R25.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(rt_max_temp < rt_r25_temp)
            {
                MessageBox.Show("The maximum temperature cannot be less than R25.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((rt_r25_temp - rt_min_temp) < 10)
            {
                MessageBox.Show("The difference between minimum temperature and R25 must be greater than 10.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((rt_max_temp - rt_r25_temp) < 10)
            {
                MessageBox.Show("The difference between maximum temperature and R25 must be greater than 10.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((tolerance < 0) || (tolerance > 100))
            {
                MessageBox.Show("Tolerance must be entered as a percentage between 0 and 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _NTC.Tolerance = tolerance;

            _NTC.MinimumRT.Resistor.Resistance = rt_min_res;
            _NTC.MinimumRT.Temperature.SetTemperature(rt_min_temp, _Unit);
            _NTC.R25.Resistor.Resistance = rt_r25_res;
            _NTC.MaximumRT.Resistor.Resistance = rt_max_res;
            _NTC.MaximumRT.Temperature.SetTemperature(rt_max_temp, _Unit);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TextRTRes_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextRTTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == '.') || (e.KeyChar == '-'))
            {
                if (e.KeyChar == '.')
                {
                    if ((sender as TextBox).Text.IndexOf('.') > -1)
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
                else if (e.KeyChar == '-')
                {
                    if ((sender as TextBox).Text.IndexOf('-') > -1)
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
