namespace NTC_Emulator.Dialogs
{
    partial class ResistorParamDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextTolerance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResInfo = new System.Windows.Forms.Label();
            this.LblResistance = new System.Windows.Forms.Label();
            this.TextResistance = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonCancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextTolerance, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblResInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblResistance, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextResistance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOk, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCancel.Location = new System.Drawing.Point(135, 70);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(126, 30);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextTolerance
            // 
            this.TextTolerance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTolerance.Location = new System.Drawing.Point(135, 43);
            this.TextTolerance.Name = "TextTolerance";
            this.TextTolerance.Size = new System.Drawing.Size(126, 21);
            this.TextTolerance.TabIndex = 4;
            this.TextTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextResistance_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tolerance(%)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblResInfo
            // 
            this.LblResInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblResInfo, 2);
            this.LblResInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResInfo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblResInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblResInfo.Location = new System.Drawing.Point(0, 0);
            this.LblResInfo.Margin = new System.Windows.Forms.Padding(0);
            this.LblResInfo.Name = "LblResInfo";
            this.LblResInfo.Size = new System.Drawing.Size(264, 13);
            this.LblResInfo.TabIndex = 0;
            this.LblResInfo.Text = "Resistor Information";
            this.LblResInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblResistance
            // 
            this.LblResistance.AutoSize = true;
            this.LblResistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResistance.ForeColor = System.Drawing.SystemColors.Control;
            this.LblResistance.Location = new System.Drawing.Point(0, 13);
            this.LblResistance.Margin = new System.Windows.Forms.Padding(0);
            this.LblResistance.Name = "LblResistance";
            this.LblResistance.Size = new System.Drawing.Size(132, 27);
            this.LblResistance.TabIndex = 1;
            this.LblResistance.Text = "Resistance(Ω, > 1Ω)";
            this.LblResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextResistance
            // 
            this.TextResistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextResistance.Location = new System.Drawing.Point(135, 16);
            this.TextResistance.Name = "TextResistance";
            this.TextResistance.Size = new System.Drawing.Size(126, 21);
            this.TextResistance.TabIndex = 2;
            this.TextResistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextResistance_KeyPress);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonOk.Location = new System.Drawing.Point(3, 70);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(126, 30);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ResistorParamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(264, 105);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResistorParamDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ResistorParamDialog";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblResInfo;
        private System.Windows.Forms.Label LblResistance;
        private System.Windows.Forms.TextBox TextResistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextTolerance;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
    }
}