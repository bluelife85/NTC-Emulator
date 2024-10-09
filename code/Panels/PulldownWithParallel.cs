using NTC_Emulator.Dialogs;
using NTC_Emulator.EmulationComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTC_Emulator.Panels
{
    public class PulldownWithParallel : ParentPanel
    {
        private Resistor Parallel = new Resistor();
        private NTC _Root = new NTC();
        public NTC NTC
        {
            set
            {
                _Root = new NTC(value);
                _NTC = _Root ^ Parallel;
            }
        }
        public PulldownWithParallel(Temperature.Units unit) : base(unit)
        {
            DesignCircuitGroup();
        }
        #region Design Circuit Region
        private ToolTip ImageVccTooltip = new ToolTip();
        private ToolTip ImageNTCTooltip = new ToolTip();
        private ToolTip ImageResistorTooltip = new ToolTip();
        private ToolTip ImageParallelTooltip = new ToolTip();

        private TableLayoutPanel TableDesignCircuit = new TableLayoutPanel();
        private PictureBox ImageVcc = new PictureBox();
        private PictureBox pictureBox1 = new PictureBox();
        private PictureBox ImageNTC = new PictureBox();
        private PictureBox pictureBox3 = new PictureBox();
        private PictureBox ImageResistor = new PictureBox();
        private PictureBox pictureBox2 = new PictureBox();
        private PictureBox pictureBox4 = new PictureBox();
        private PictureBox ImageParallel = new PictureBox();
        private PictureBox pictureBox7 = new PictureBox();
        private PictureBox pictureBox6 = new PictureBox();
        private PictureBox[] ImageHandler = new PictureBox[10];
        private Label label1 = new Label();

        public event DialogNotification DialogEvent;
        public override void DesignCircuitGroup()
        {
            ImageHandler[0] = ImageVcc;
            ImageHandler[1] = ImageNTC;
            ImageHandler[2] = ImageResistor;
            ImageHandler[3] = pictureBox2;
            ImageHandler[4] = pictureBox3;
            ImageHandler[5] = pictureBox4;
            ImageHandler[6] = pictureBox1;
            ImageHandler[7] = pictureBox6;
            ImageHandler[8] = pictureBox7;
            ImageHandler[9] = ImageParallel;

            TableDesignCircuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageVcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageNTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageResistor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageParallel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();

            RadioResistance.Text = "Input Comb. Res";

            // 
            // TableDesignCircuit
            // 
            this.TableDesignCircuit.ColumnCount = 4;
            this.TableDesignCircuit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableDesignCircuit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableDesignCircuit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableDesignCircuit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableDesignCircuit.Controls.Add(this.pictureBox7, 2, 2);
            this.TableDesignCircuit.Controls.Add(this.pictureBox6, 1, 4);
            this.TableDesignCircuit.Controls.Add(this.ImageParallel, 1, 3);
            this.TableDesignCircuit.Controls.Add(this.pictureBox4, 1, 2);
            this.TableDesignCircuit.Controls.Add(this.pictureBox2, 0, 5);
            this.TableDesignCircuit.Controls.Add(this.ImageResistor, 0, 1);
            this.TableDesignCircuit.Controls.Add(this.pictureBox3, 0, 4);
            this.TableDesignCircuit.Controls.Add(this.ImageNTC, 0, 3);
            this.TableDesignCircuit.Controls.Add(this.pictureBox1, 0, 2);
            this.TableDesignCircuit.Controls.Add(this.ImageVcc, 0, 0);
            this.TableDesignCircuit.Controls.Add(this.label1, 3, 2);
            this.TableDesignCircuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDesignCircuit.Location = new System.Drawing.Point(3, 17);
            this.TableDesignCircuit.Name = "TableDesignCircuit";
            this.TableDesignCircuit.RowCount = 6;
            this.TableDesignCircuit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableDesignCircuit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableDesignCircuit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableDesignCircuit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableDesignCircuit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableDesignCircuit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableDesignCircuit.Size = new System.Drawing.Size(254, 403);
            this.TableDesignCircuit.TabIndex = 0;
            // 
            // ImageVcc
            // 
            this.ImageVcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageVcc.Image = global::NTC_Emulator.Properties.Resources.three_way_south;
            this.ImageVcc.Location = new System.Drawing.Point(0, 0);
            this.ImageVcc.Margin = new System.Windows.Forms.Padding(0);
            this.ImageVcc.Name = "ImageVcc";
            this.ImageVcc.Size = new System.Drawing.Size(50, 50);
            this.ImageVcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageVcc.TabIndex = 0;
            this.ImageVcc.TabStop = false;
            this.ImageVcc.MouseHover += ImageVcc_MouseHover;
            this.ImageVcc.Click += ImageVcc_Click;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::NTC_Emulator.Properties.Resources.three_way_east;
            this.pictureBox1.Location = new System.Drawing.Point(0, 150);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ImageNTC
            // 
            this.ImageNTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageNTC.Image = global::NTC_Emulator.Properties.Resources.ntc;
            this.ImageNTC.Location = new System.Drawing.Point(0, 200);
            this.ImageNTC.Margin = new System.Windows.Forms.Padding(0);
            this.ImageNTC.Name = "ImageNTC";
            this.ImageNTC.Size = new System.Drawing.Size(50, 100);
            this.ImageNTC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageNTC.TabIndex = 2;
            this.ImageNTC.TabStop = false;
            this.ImageNTC.MouseHover += ImageNTC_MouseHover;
            this.ImageNTC.Click += ImageNTC_Click;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::NTC_Emulator.Properties.Resources.three_way_east;
            this.pictureBox3.Location = new System.Drawing.Point(0, 300);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // ImageResistor
            // 
            this.ImageResistor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageResistor.Image = global::NTC_Emulator.Properties.Resources.resistor;
            this.ImageResistor.Location = new System.Drawing.Point(0, 50);
            this.ImageResistor.Margin = new System.Windows.Forms.Padding(0);
            this.ImageResistor.Name = "ImageResistor";
            this.ImageResistor.Size = new System.Drawing.Size(50, 100);
            this.ImageResistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageResistor.TabIndex = 4;
            this.ImageResistor.TabStop = false;
            this.ImageResistor.MouseHover += ImageResistor_MouseHover;
            this.ImageResistor.Click += ImageResistor_Click;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::NTC_Emulator.Properties.Resources.gnd;
            this.pictureBox2.Location = new System.Drawing.Point(0, 350);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::NTC_Emulator.Properties.Resources.three_way_south;
            this.pictureBox4.Location = new System.Drawing.Point(50, 150);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // ImageParallel
            // 
            this.ImageParallel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageParallel.Image = global::NTC_Emulator.Properties.Resources.resistor;
            this.ImageParallel.Location = new System.Drawing.Point(50, 200);
            this.ImageParallel.Margin = new System.Windows.Forms.Padding(0);
            this.ImageParallel.Name = "ImageParallel";
            this.ImageParallel.Size = new System.Drawing.Size(50, 100);
            this.ImageParallel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageParallel.TabIndex = 7;
            this.ImageParallel.TabStop = false;
            this.ImageParallel.MouseHover += ImageParallel_MouseHover;
            this.ImageParallel.Click += ImageParallel_Click;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::NTC_Emulator.Properties.Resources.pulldown_parellel_head;
            this.pictureBox6.Location = new System.Drawing.Point(50, 300);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::NTC_Emulator.Properties.Resources.non_parellel_out;
            this.pictureBox7.Location = new System.Drawing.Point(100, 150);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(153, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            GroupCircuit.Controls.Add(this.TableDesignCircuit);
            // 
            // NtcPanelParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(607, 545);
            this.ControlBox = false;
            this.Controls.Add(this.GroupCircuit);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NtcPanelParent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NtcPanelParent";

            ButtonGenerate.Click += ButtonGenerateClickEvent;

            GroupCircuit.ResumeLayout(false);
            this.TableDesignCircuit.ResumeLayout(false);
            this.TableDesignCircuit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageVcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageNTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageResistor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageParallel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            RadioResistance.Checked = true;
            _NTC = _Root ^ Parallel;
            UpdateParentComponent();
        }

        private void ImageParallel_Click(object sender, EventArgs e)
        {
            ResistorParamDialog dialog = new ResistorParamDialog(Parallel);
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = false;
            }
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            BackColor = Color.FromArgb(((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))));
            DialogEvent?.Invoke(true);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                Parallel = dialog.Resistor;
                _NTC = _Root ^ Parallel;
            }
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = true;
            }
            BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            DialogEvent?.Invoke(false);
        }

        private void ImageParallel_MouseHover(object sender, EventArgs e)
        {
            ImageParallelTooltip.ToolTipTitle = "Resistor Information";
            ImageParallelTooltip.SetToolTip(ImageParallel,
                "Resistance : " + Parallel.Resistance + " Ω\n"
                + "Tolerance : " + Parallel.Tolerance + " %"
                );
        }

        private void ImageResistor_Click(object sender, EventArgs e)
        {
            ResistorParamDialog dialog = new ResistorParamDialog(_Resistor);
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = false;
            }
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            BackColor = Color.FromArgb(((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))));
            DialogEvent?.Invoke(true);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                _Resistor = dialog.Resistor;
            }
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = true;
            }
            BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            DialogEvent?.Invoke(false);
        }

        private void ImageResistor_MouseHover(object sender, EventArgs e)
        {
            ImageResistorTooltip.ToolTipTitle = "Resistor Information";
            ImageResistorTooltip.SetToolTip(ImageResistor,
                "Resistance : " + _Resistor.Resistance + " Ω\n"
                + "Tolerance : " + _Resistor.Tolerance + " %"
                );
        }

        private void ImageNTC_Click(object sender, EventArgs e)
        {
            NTCParamDialog dialog = new NTCParamDialog(_Root, _Unit);
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = false;
            }
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            BackColor = Color.FromArgb(((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))));
            DialogEvent?.Invoke(true);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                _Root = new NTC(dialog.NTC);
                _NTC = _Root ^ Parallel;
                UpdateParentComponent();
            }
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = true;
            }
            BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            DialogEvent?.Invoke(false);
        }

        private void ImageNTC_MouseHover(object sender, EventArgs e)
        {
            ImageNTCTooltip.ToolTipTitle = "NTC Information";
            ImageNTCTooltip.SetToolTip(ImageNTC,
                "RTmin : " + _Root.MinimumRT.Resistance + " Ω @ " + _Root.MinimumRT.Temperature.GetTemperature(_Unit) + " " + Temperature.GetDescription(_Unit) + "\n"
                + "RT25 : " + _Root.R25.Resistance + " Ω @ " + _Root.R25.Temperature.GetTemperature(_Unit) + " " + Temperature.GetDescription(_Unit) + "\n"
                + "RTmax : " + _Root.MaximumRT.Resistance + " Ω @ " + _Root.MaximumRT.Temperature.GetTemperature(_Unit) + " " + Temperature.GetDescription(_Unit) + "\n"
                );
        }

        private void ImageVcc_Click(object sender, EventArgs e)
        {
            VinDialog dialog = new VinDialog(_Vin);
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = false;
            }
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            BackColor = Color.FromArgb(((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))));
            DialogEvent?.Invoke(true);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                _Vin = dialog.VIN;
            }
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = true;
            }
            BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            DialogEvent?.Invoke(false);
        }

        private void ImageVcc_MouseHover(object sender, EventArgs e)
        {
            ImageVccTooltip.ToolTipTitle = "Circuit Input Voltage";
            ImageVccTooltip.SetToolTip(ImageVcc, "V input = " + _Vin.ToString() + " V");
        }

        public override void ButtonGenerateClickEvent(object sender, EventArgs e)
        {
            CodeGenerateDialog dialog = new CodeGenerateDialog(new EmulationInfo(_Vin, _NTC, _Resistor, false), _Unit);
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = false;
            }
            BackColor = Color.FromArgb(((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))), ((int)(((byte)(BACK_COLOR_CODE)))));
            DialogEvent?.Invoke(true);
            dialog.ShowDialog();
            foreach (PictureBox pb in ImageHandler)
            {
                pb.Visible = true;
            }
            BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            DialogEvent?.Invoke(false);
        }
        #endregion
    }
}
