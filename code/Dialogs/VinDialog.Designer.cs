namespace NTC_Emulator.Dialogs
{
    partial class VinDialog
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
            this.DialogLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelReq = new System.Windows.Forms.Label();
            this.TextVin = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.DialogLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogLayout
            // 
            this.DialogLayout.ColumnCount = 2;
            this.DialogLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DialogLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DialogLayout.Controls.Add(this.ButtonCancel, 1, 2);
            this.DialogLayout.Controls.Add(this.LabelReq, 0, 0);
            this.DialogLayout.Controls.Add(this.TextVin, 0, 1);
            this.DialogLayout.Controls.Add(this.ButtonOk, 0, 2);
            this.DialogLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogLayout.Location = new System.Drawing.Point(0, 0);
            this.DialogLayout.Margin = new System.Windows.Forms.Padding(0);
            this.DialogLayout.Name = "DialogLayout";
            this.DialogLayout.RowCount = 3;
            this.DialogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DialogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DialogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DialogLayout.Size = new System.Drawing.Size(233, 76);
            this.DialogLayout.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCancel.Location = new System.Drawing.Point(119, 42);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(111, 30);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseMnemonic = false;
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // LabelReq
            // 
            this.LabelReq.AutoSize = true;
            this.DialogLayout.SetColumnSpan(this.LabelReq, 2);
            this.LabelReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelReq.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelReq.Location = new System.Drawing.Point(3, 0);
            this.LabelReq.Name = "LabelReq";
            this.LabelReq.Size = new System.Drawing.Size(227, 12);
            this.LabelReq.TabIndex = 0;
            this.LabelReq.Text = "Input a Vin Level in [V] (1.2V ~ 6V)";
            this.LabelReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextVin
            // 
            this.DialogLayout.SetColumnSpan(this.TextVin, 2);
            this.TextVin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextVin.Location = new System.Drawing.Point(3, 15);
            this.TextVin.Name = "TextVin";
            this.TextVin.Size = new System.Drawing.Size(227, 21);
            this.TextVin.TabIndex = 1;
            this.TextVin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextVin_KeyPress);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonOk.Location = new System.Drawing.Point(3, 42);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(110, 30);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // VinDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(233, 76);
            this.ControlBox = false;
            this.Controls.Add(this.DialogLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VinDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VinDialog";
            this.TopMost = true;
            this.DialogLayout.ResumeLayout(false);
            this.DialogLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DialogLayout;
        private System.Windows.Forms.Label LabelReq;
        private System.Windows.Forms.TextBox TextVin;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
    }
}