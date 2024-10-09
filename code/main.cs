using NTC_Emulator.EmulationComponent;
using NTC_Emulator.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTC_Emulator
{
    public partial class main : Form
    {
        private ParentPanel[] AppPanels = new ParentPanel[4];
        public main()
        {
            InitializeComponent();
            AppPanels[0] = new PullupPanel(Temperature.Units.Celsius);
            AppPanels[1] = new PullupWithParellel(Temperature.Units.Celsius);
            AppPanels[2] = new PulldownPanel(Temperature.Units.Celsius);
            AppPanels[3] = new PulldownWithParallel(Temperature.Units.Celsius);
        }

        private void main_Load(object sender, EventArgs e)
        {
            foreach(var panel in AppPanels)
            {
                panel.StartPosition = FormStartPosition.Manual;
                panel.Location = new Point(Location.X + Width, Location.Y + LabelAppName.Height);
                panel.Hide();
                panel.Unit = Temperature.Units.Celsius;
            }
            ComboTempUnit.SelectedIndex = 0;
            ComboCircuitType.SelectedIndex = 0;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region App Move Code
        private bool IsMouseDown = false;
        private Point MouseOffset;
        private void LabelAppName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseOffset = new Point(-e.X, -e.Y);
                IsMouseDown = true;
            }
        }

        private void LabelAppName_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(MouseOffset.X, MouseOffset.Y);
                this.Location = mousePos;

                foreach (var panel in AppPanels)
                {
                    panel.Location = new Point(Location.X + Width, Location.Y + LabelAppName.Height);
                }
            }
        }

        private void LabelAppName_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = false;
            }
        }
        #endregion

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contact : bluelife85@naver.com");
        }
        #region Circuit type selection & sliding
        private const int SLIDING_STEP = 50;
        private int MaxSlidingPos;
        private int MaxHeight;
        private int CurrentSlidingPos;

        private bool IsRollup;
        private ParentPanel CurrentForm = null;
        private ParentPanel NextForm = null;
        private void SlidingTimer_Tick(object sender, EventArgs e)
        {
            if (!IsRollup)
            {
                if (CurrentForm == null)
                {
                    IsRollup = true;
                    CurrentForm = NextForm;
                    CurrentForm.Show();
                }
                else
                {
                    CurrentSlidingPos -= SLIDING_STEP;
                    if (CurrentSlidingPos < 0)
                    {
                        IsRollup = true;
                        CurrentSlidingPos = 0;
                        CurrentForm.Size = new Size(0, 0);
                        CurrentForm = NextForm;
                        CurrentForm.Height = MaxHeight;
                        CurrentForm.Hide();
                        NextForm.Show();
                    }

                    CurrentForm.Width = CurrentSlidingPos;
                }
            }
            else
            {
                CurrentSlidingPos += SLIDING_STEP;
                if (CurrentSlidingPos >= MaxSlidingPos)
                {
                    CurrentSlidingPos = MaxSlidingPos;
                    SlidingTimer.Stop();
                }

                CurrentForm.Width = CurrentSlidingPos;
            }
        }

        private void ComboCircuitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextForm = AppPanels[ComboCircuitType.SelectedIndex];
            MaxSlidingPos = NextForm.MAX_WIDTH;
            MaxHeight = NextForm.MAX_HEIGHT;
            NextForm.Size = new Size(0, MaxHeight);
            IsRollup = false;
            SlidingTimer.Start();
        }
        #endregion

        private void ComboTempUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ComboTempUnit.SelectedIndex)
            {
                case 0:
                    foreach (var panel in AppPanels)
                        panel.Unit = Temperature.Units.Celsius;
                    break;
                case 1:
                    foreach (var panel in AppPanels)
                        panel.Unit = Temperature.Units.Fahrenheit;
                    break;
                case 2:
                    foreach (var panel in AppPanels)
                        panel.Unit = Temperature.Units.Kelvin;
                    break;
            }
        }
    }
}
