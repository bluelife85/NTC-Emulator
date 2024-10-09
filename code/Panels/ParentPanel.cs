using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using NTC_Emulator.EmulationComponent;

namespace NTC_Emulator.Panels
{
    public abstract class ParentPanel : Form
    {
        public int MAX_WIDTH = 607;
        public int MAX_HEIGHT = 545;
        protected const int BACK_COLOR_CODE = 90;
        protected NTC _NTC = new NTC();
        protected Resistor _Resistor = new Resistor();
        protected bool IsTemperatureMode = false;
        protected Temperature.Units _Unit;
        protected int NbrOfData;
        protected double InputValue;
        protected double OutputValue;
        protected double[] AxisXValues;
        protected double[] AxisYValues;
        protected double[] AxisYMinValues;
        protected double[] AxisYMaxValues;

        protected double _Vin;
        
        public Temperature.Units Unit
        {
            set
            {
                _Unit = value;
                UpdateParentComponent();
            }
        }
        public ParentPanel(Temperature.Units unit)
        {
            _Unit = unit;
            _Vin = 3.3;
            ArrangeParentControls();
        }
        public abstract void DesignCircuitGroup();
        public abstract void ButtonGenerateClickEvent(object sender, EventArgs e);
        #region Component Code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected GroupBox GroupCircuit = new GroupBox();
        protected GroupBox groupBox2 = new GroupBox();
        protected GroupBox groupBox3 = new GroupBox();
        protected RadioButton RadioTemperature = new RadioButton();
        protected RadioButton RadioResistance = new RadioButton();
        protected TextBox TextInput = new TextBox();
        protected Label LblInputUnit = new Label();
        protected Label LblOutputUnit = new Label();
        protected TextBox TextOutput = new TextBox();
        protected Label label3 = new Label();
        protected LiveCharts.WinForms.CartesianChart RTGraph = new LiveCharts.WinForms.CartesianChart();
        protected Button ButtonGenerate = new Button();
        protected TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        protected Label LabelA = new Label();
        protected Label LabelB = new Label();
        protected Label LabelC = new Label();
        protected RichTextBox TextA = new RichTextBox();
        protected RichTextBox TextB = new RichTextBox();
        protected RichTextBox TextC = new RichTextBox();

        protected void ArrangeParentControls()
        {
            GroupCircuit.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            // 
            // GroupCircuit
            // 
            this.GroupCircuit.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupCircuit.Location = new System.Drawing.Point(0, 0);
            this.GroupCircuit.Name = "GroupCircuit";
            this.GroupCircuit.Size = new System.Drawing.Size(260, 423);
            this.GroupCircuit.TabIndex = 0;
            this.GroupCircuit.TabStop = false;
            this.GroupCircuit.Text = "Circuit";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(1, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coefficients";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.LabelA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextC, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 93);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelA.Location = new System.Drawing.Point(3, 0);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(58, 30);
            this.LabelA.TabIndex = 1;
            this.LabelA.Text = "A";
            this.LabelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelB.Location = new System.Drawing.Point(3, 30);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(58, 31);
            this.LabelB.TabIndex = 2;
            this.LabelB.Text = "B";
            this.LabelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelC.Location = new System.Drawing.Point(3, 61);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(58, 32);
            this.LabelC.TabIndex = 3;
            this.LabelC.Text = "C";
            this.LabelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextA
            // 
            this.TextA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextA.Location = new System.Drawing.Point(67, 3);
            this.TextA.Multiline = false;
            this.TextA.Name = "TextA";
            this.TextA.ReadOnly = true;
            this.TextA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextA.Size = new System.Drawing.Size(186, 24);
            this.TextA.TabIndex = 7;
            this.TextA.Text = "0.123456789e-12";
            // 
            // TextB
            // 
            this.TextB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextB.Location = new System.Drawing.Point(67, 33);
            this.TextB.Multiline = false;
            this.TextB.Name = "TextB";
            this.TextB.ReadOnly = true;
            this.TextB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextB.Size = new System.Drawing.Size(186, 25);
            this.TextB.TabIndex = 8;
            this.TextB.Text = "0.123456789e-12";
            // 
            // TextC
            // 
            this.TextC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextC.Location = new System.Drawing.Point(67, 64);
            this.TextC.Multiline = false;
            this.TextC.Name = "TextC";
            this.TextC.ReadOnly = true;
            this.TextC.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextC.Size = new System.Drawing.Size(186, 26);
            this.TextC.TabIndex = 9;
            this.TextC.Text = "0.123456789e-12";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RTGraph);
            this.groupBox3.Controls.Add(this.LblOutputUnit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LblInputUnit);
            this.groupBox3.Controls.Add(this.TextOutput);
            this.groupBox3.Controls.Add(this.TextInput);
            this.groupBox3.Controls.Add(this.RadioTemperature);
            this.groupBox3.Controls.Add(this.RadioResistance);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(266, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 500);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "R-T Result";
            // 
            // RTGraph
            // 
            this.RTGraph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RTGraph.Location = new System.Drawing.Point(3, 66);
            this.RTGraph.Name = "RTGraph";
            this.RTGraph.Size = new System.Drawing.Size(333, 431);
            this.RTGraph.TabIndex = 4;
            this.RTGraph.Text = "cartesianChart1";
            RTGraph.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Temperature",
                Labels = new[] { "-40.00", "25.00", "40.00" },
                LabelsRotation = 135,
                Separator = new Separator
                {
                    Step = 2
                }
            });
            // 
            // LblOutputUnit
            // 
            this.LblOutputUnit.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblOutputUnit.Location = new System.Drawing.Point(305, 42);
            this.LblOutputUnit.Name = "LblOutputUnit";
            this.LblOutputUnit.Size = new System.Drawing.Size(24, 21);
            this.LblOutputUnit.TabIndex = 3;
            this.LblOutputUnit.Text = "℃";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(151, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "--->";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblInputUnit
            // 
            this.LblInputUnit.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblInputUnit.Location = new System.Drawing.Point(127, 42);
            this.LblInputUnit.Name = "LblInputUnit";
            this.LblInputUnit.Size = new System.Drawing.Size(24, 21);
            this.LblInputUnit.TabIndex = 3;
            this.LblInputUnit.Text = "Ω";
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(201, 42);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.Size = new System.Drawing.Size(98, 21);
            this.TextOutput.TabIndex = 2;
            this.TextOutput.TabStop = false;
            this.TextOutput.Text = "25.000";
            this.TextOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(23, 42);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(98, 21);
            this.TextInput.TabIndex = 2;
            this.TextInput.Text = "10000.000";
            this.TextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            this.TextInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextInput_KeyPress);
            // 
            // RadioTemperature
            // 
            this.RadioTemperature.AutoSize = true;
            this.RadioTemperature.Location = new System.Drawing.Point(192, 20);
            this.RadioTemperature.Name = "RadioTemperature";
            this.RadioTemperature.Size = new System.Drawing.Size(126, 16);
            this.RadioTemperature.TabIndex = 1;
            this.RadioTemperature.Text = "Input Temperature";
            this.RadioTemperature.UseVisualStyleBackColor = true;
            this.RadioTemperature.CheckedChanged += new System.EventHandler(this.RadioResistance_CheckedChanged);
            // 
            // RadioResistance
            // 
            this.RadioResistance.AutoSize = true;
            this.RadioResistance.Location = new System.Drawing.Point(17, 20);
            this.RadioResistance.Name = "RadioResistance";
            this.RadioResistance.Size = new System.Drawing.Size(117, 16);
            this.RadioResistance.TabIndex = 0;
            this.RadioResistance.Text = "Input Resistance";
            this.RadioResistance.UseVisualStyleBackColor = true;
            this.RadioResistance.CheckedChanged += new System.EventHandler(this.RadioResistance_CheckedChanged);
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonGenerate.Location = new System.Drawing.Point(269, 505);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(333, 36);
            this.ButtonGenerate.TabIndex = 3;
            this.ButtonGenerate.Text = "Gnerate Table";
            this.ButtonGenerate.UseVisualStyleBackColor = false;
        }
        protected void TextInput_KeyPress(object sender, KeyPressEventArgs e)
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

        protected void TextInput_TextChanged(object sender, EventArgs e)
        {
            TextInput.TextChanged -= TextInput_TextChanged;
            if (IsTemperatureMode)
            {
                Temperature tempValue = new Temperature();
                double d;
                double.TryParse(TextInput.Text, out d);
                tempValue.SetTemperature(d, _Unit);

                OutputValue = _NTC.ConvertToResistance(tempValue);
                TextOutput.Text = OutputValue.ToString("0.000");
            }
            else
            {
                double resValue;
                double.TryParse(TextInput.Text, out resValue);
                if (resValue < 1)
                {
                    InputValue = 1;
                    TextInput.Text = InputValue.ToString("0.000");
                }
                else
                {
                    InputValue = resValue;
                }

                Temperature temperature = _NTC.ConvertToTemperature(InputValue);
                OutputValue = temperature.GetTemperature(_Unit);
                TextOutput.Text = OutputValue.ToString("0.000");
            }
            TextInput.TextChanged += TextInput_TextChanged;
        }
        protected void RadioResistance_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioResistance.Checked)
            {
                IsTemperatureMode = false;
                InputValue = 10000;
                TextInput.Text = InputValue.ToString("0.000");
                LblInputUnit.Text = "Ω";
                Temperature tmp = _NTC.ConvertToTemperature(InputValue);
                LblOutputUnit.Text = Temperature.GetDescription(_Unit);
                OutputValue = tmp.GetTemperature(_Unit);
                TextOutput.Text = OutputValue.ToString("0.000");
            }
            else
            {
                IsTemperatureMode = true;
                Temperature tmp = new Temperature();
                tmp.Celsius = 25.000;
                LblInputUnit.Text = Temperature.GetDescription(_Unit);
                InputValue = tmp.GetTemperature(_Unit);

                TextInput.Text = InputValue.ToString("0.000");
                OutputValue = _NTC.ConvertToResistance(tmp);
                LblOutputUnit.Text = "Ω";
                TextOutput.Text = OutputValue.ToString("0.000");
            }
        }
        #endregion
        protected void UpdateParentComponent()
        {
            UpdateCoefficients(_NTC);
            if(!IsTemperatureMode)
            {
                LblInputUnit.Text = "Ω";
                LblOutputUnit.Text = Temperature.GetDescription(_Unit);
                Temperature tmp = _NTC.ConvertToTemperature(InputValue);
                OutputValue = tmp.GetTemperature(_Unit);
                TextOutput.Text = OutputValue.ToString("0.000");
            }
            else
            {
                LblInputUnit.Text = Temperature.GetDescription(_Unit);
                LblOutputUnit.Text = "Ω";
                Temperature tmp = new Temperature();
                tmp.SetTemperature(InputValue, _Unit);
                TextInput.Text = InputValue.ToString("0.000");
                OutputValue = _NTC.ConvertToResistance(tmp);
                TextOutput.Text = OutputValue.ToString("0.000");
            }
            UpdateGraphData();
        }
        protected double[] GetAxisX()
        {
            int nbr = 0;
            double min = _NTC.MinimumRT.Temperature.GetTemperature(_Unit);
            double max = _NTC.MaximumRT.Temperature.GetTemperature(_Unit);
            int diff;
            double[] ret;

            diff = ((int)(max - min));
            if (diff % 5 == 0)
            {
                nbr = diff / 5 + 1;
            }
            else
            {
                nbr = diff / 5 + 2;
            }

            ret = new double[nbr];
            for (int i = 0; i < nbr; i++)
            {
                ret[i] = min + (i * 5);
            }
            ret[nbr - 1] = max;
            NbrOfData = nbr;
            return ret;
        }
        protected double[] GetMinAxisY()
        {
            double[] ret = new double[NbrOfData];
            Temperature temperature = new Temperature();
            Resistor res = new Resistor();
            for (int i = 0; i < NbrOfData; i++)
            {
                temperature.SetTemperature(AxisXValues[i], _Unit);
                res.Resistance = _NTC.ConvertToResistance(temperature);
                ret[i] = res.Minimum;
            }
            return ret;
        }
        protected double[] GetMaxAxisY()
        {
            double[] ret = new double[NbrOfData];
            Temperature temperature = new Temperature();
            Resistor res = new Resistor();
            for (int i = 0; i < NbrOfData; i++)
            {
                temperature.SetTemperature(AxisXValues[i], _Unit);
                res.Resistance = _NTC.ConvertToResistance(temperature);
                ret[i] = res.Maximum;
            }
            return ret;
        }
        protected double[] GetAxisY()
        {
            double[] ret = new double[NbrOfData];
            Temperature temperature = new Temperature();
            for (int i = 0; i < NbrOfData; i++)
            {
                temperature.SetTemperature(AxisXValues[i], _Unit);
                ret[i] = _NTC.ConvertToResistance(temperature);
            }
            return ret;
        }
        protected void UpdateGraphData()
        {
            string[] XLabels;

            AxisXValues = GetAxisX();
            AxisYMinValues = GetMinAxisY();
            AxisYMaxValues = GetMaxAxisY();
            AxisYValues = GetAxisY();

            XLabels = new string[AxisXValues.Length];
            for (int i = 0; i < AxisXValues.Length; i++)
            {
                XLabels[i] = AxisXValues[i].ToString("0.00");
            }

            RTGraph.AxisX[0].Labels = XLabels;
            RTGraph.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Resistance",
                    Values = new ChartValues<double>(AxisYValues)
                },
                new LineSeries
                {
                    Title = "Min",
                    Values = new ChartValues<double>(AxisYMinValues)
                },
                new LineSeries
                {
                    Title = "Max",
                    Values = new ChartValues<double>(AxisYMaxValues)
                },
            };
        }
        protected void UpdateCoefficients(NTC ntc)
        {
            TextA.Text = ShowExponent(ntc.A);
            TextB.Text = ShowExponent(ntc.B);
            TextC.Text = ShowExponent(ntc.C);
        }
        private string ShowExponent(double data)
        {
            string ret = null;
            int exp = 0, temp = 0;

            for (exp = 0; exp < 16; exp++)
            {
                temp = (int)data;
                if (temp != 0)
                {
                    break;
                }
                else
                {
                    data *= (10.0);
                }
            }

            if (exp == 16 && temp == 0)
                ret = "0.000000000000e-0";
            else
                ret = data.ToString("0.000000000000") + "e-" + exp.ToString();

            return ret;
        }
        public delegate void DialogNotification(bool IsOpened);
        
    }
}
