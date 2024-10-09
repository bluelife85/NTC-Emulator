namespace NTC_Emulator
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.TableMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.ComboTempUnit = new System.Windows.Forms.ComboBox();
            this.LabelTempUnit = new System.Windows.Forms.Label();
            this.LabelAppName = new System.Windows.Forms.Label();
            this.LabelCircuitType = new System.Windows.Forms.Label();
            this.ComboCircuitType = new System.Windows.Forms.ComboBox();
            this.ButtonPreset = new System.Windows.Forms.Button();
            this.SlidingTimer = new System.Windows.Forms.Timer(this.components);
            this.TableMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableMain
            // 
            this.TableMain.ColumnCount = 1;
            this.TableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableMain.Controls.Add(this.ButtonClose, 0, 7);
            this.TableMain.Controls.Add(this.ButtonAbout, 0, 6);
            this.TableMain.Controls.Add(this.ComboTempUnit, 0, 4);
            this.TableMain.Controls.Add(this.LabelTempUnit, 0, 3);
            this.TableMain.Controls.Add(this.LabelAppName, 0, 0);
            this.TableMain.Controls.Add(this.LabelCircuitType, 0, 1);
            this.TableMain.Controls.Add(this.ComboCircuitType, 0, 2);
            this.TableMain.Controls.Add(this.ButtonPreset, 0, 5);
            this.TableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableMain.Location = new System.Drawing.Point(0, 0);
            this.TableMain.Margin = new System.Windows.Forms.Padding(0);
            this.TableMain.Name = "TableMain";
            this.TableMain.RowCount = 8;
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableMain.Size = new System.Drawing.Size(209, 202);
            this.TableMain.TabIndex = 0;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonClose.Location = new System.Drawing.Point(3, 167);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(203, 30);
            this.ButtonClose.TabIndex = 7;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAbout.Location = new System.Drawing.Point(3, 131);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(203, 30);
            this.ButtonAbout.TabIndex = 6;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ComboTempUnit
            // 
            this.ComboTempUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTempUnit.FormattingEnabled = true;
            this.ComboTempUnit.Items.AddRange(new object[] {
            "℃",
            "℉",
            "Kelvin"});
            this.ComboTempUnit.Location = new System.Drawing.Point(3, 69);
            this.ComboTempUnit.Name = "ComboTempUnit";
            this.ComboTempUnit.Size = new System.Drawing.Size(203, 20);
            this.ComboTempUnit.TabIndex = 4;
            this.ComboTempUnit.SelectedIndexChanged += new System.EventHandler(this.ComboTempUnit_SelectedIndexChanged);
            // 
            // LabelTempUnit
            // 
            this.LabelTempUnit.AutoSize = true;
            this.LabelTempUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTempUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTempUnit.Location = new System.Drawing.Point(3, 54);
            this.LabelTempUnit.Name = "LabelTempUnit";
            this.LabelTempUnit.Size = new System.Drawing.Size(203, 12);
            this.LabelTempUnit.TabIndex = 3;
            this.LabelTempUnit.Text = "Temperature Unit";
            this.LabelTempUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAppName
            // 
            this.LabelAppName.AutoSize = true;
            this.LabelAppName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAppName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelAppName.Location = new System.Drawing.Point(0, 0);
            this.LabelAppName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelAppName.Name = "LabelAppName";
            this.LabelAppName.Size = new System.Drawing.Size(209, 16);
            this.LabelAppName.TabIndex = 0;
            this.LabelAppName.Text = "NTC Emulator";
            this.LabelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelAppName_MouseDown);
            this.LabelAppName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelAppName_MouseMove);
            this.LabelAppName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelAppName_MouseUp);
            // 
            // LabelCircuitType
            // 
            this.LabelCircuitType.AutoSize = true;
            this.LabelCircuitType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCircuitType.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCircuitType.Location = new System.Drawing.Point(3, 16);
            this.LabelCircuitType.Name = "LabelCircuitType";
            this.LabelCircuitType.Size = new System.Drawing.Size(203, 12);
            this.LabelCircuitType.TabIndex = 1;
            this.LabelCircuitType.Text = "Circuit Type";
            this.LabelCircuitType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboCircuitType
            // 
            this.ComboCircuitType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboCircuitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCircuitType.FormattingEnabled = true;
            this.ComboCircuitType.Items.AddRange(new object[] {
            "Pullup",
            "Pullup with parallel resistor",
            "Pulldown",
            "Pulldown with parallel resistor"});
            this.ComboCircuitType.Location = new System.Drawing.Point(3, 31);
            this.ComboCircuitType.Name = "ComboCircuitType";
            this.ComboCircuitType.Size = new System.Drawing.Size(203, 20);
            this.ComboCircuitType.TabIndex = 2;
            this.ComboCircuitType.SelectedIndexChanged += new System.EventHandler(this.ComboCircuitType_SelectedIndexChanged);
            // 
            // ButtonPreset
            // 
            this.ButtonPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPreset.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPreset.Enabled = false;
            this.ButtonPreset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPreset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonPreset.Location = new System.Drawing.Point(3, 95);
            this.ButtonPreset.Name = "ButtonPreset";
            this.ButtonPreset.Size = new System.Drawing.Size(203, 30);
            this.ButtonPreset.TabIndex = 5;
            this.ButtonPreset.UseVisualStyleBackColor = false;
            // 
            // SlidingTimer
            // 
            this.SlidingTimer.Interval = 10;
            this.SlidingTimer.Tick += new System.EventHandler(this.SlidingTimer_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(209, 202);
            this.ControlBox = false;
            this.Controls.Add(this.TableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "NTC Emulator";
            this.Load += new System.EventHandler(this.main_Load);
            this.TableMain.ResumeLayout(false);
            this.TableMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableMain;
        private System.Windows.Forms.Label LabelAppName;
        private System.Windows.Forms.Label LabelCircuitType;
        private System.Windows.Forms.ComboBox ComboCircuitType;
        private System.Windows.Forms.Label LabelTempUnit;
        private System.Windows.Forms.ComboBox ComboTempUnit;
        private System.Windows.Forms.Button ButtonPreset;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Timer SlidingTimer;
    }
}

