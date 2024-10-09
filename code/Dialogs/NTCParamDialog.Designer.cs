namespace NTC_Emulator.Dialogs
{
    partial class NTCParamDialog
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
            this.TextTolerance = new System.Windows.Forms.TextBox();
            this.TextRTMaxTemp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextRTMaxRes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextR25Temp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextR25Res = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextRTMinTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblResInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextRTMinRes = new System.Windows.Forms.TextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.TextTolerance, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.TextRTMaxTemp, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TextRTMaxRes, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TextR25Temp, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextR25Res, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextRTMinTemp, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblResInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextRTMinRes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOk, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCancel, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 240);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TextTolerance
            // 
            this.TextTolerance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTolerance.Location = new System.Drawing.Point(301, 180);
            this.TextTolerance.Name = "TextTolerance";
            this.TextTolerance.Size = new System.Drawing.Size(145, 21);
            this.TextTolerance.TabIndex = 19;
            // 
            // TextRTMaxTemp
            // 
            this.TextRTMaxTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRTMaxTemp.Location = new System.Drawing.Point(301, 153);
            this.TextRTMaxTemp.Name = "TextRTMaxTemp";
            this.TextRTMaxTemp.Size = new System.Drawing.Size(145, 21);
            this.TextRTMaxTemp.TabIndex = 15;
            this.TextRTMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextRTTemp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(149, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Temperature";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextRTMaxRes
            // 
            this.TextRTMaxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRTMaxRes.Location = new System.Drawing.Point(301, 126);
            this.TextRTMaxRes.Name = "TextRTMaxRes";
            this.TextRTMaxRes.Size = new System.Drawing.Size(145, 21);
            this.TextRTMaxRes.TabIndex = 13;
            this.TextRTMaxRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextRTRes_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(149, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Resistance";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(0, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.tableLayoutPanel1.SetRowSpan(this.label7, 2);
            this.label7.Size = new System.Drawing.Size(149, 54);
            this.label7.TabIndex = 11;
            this.label7.Text = "RT Maximum";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextR25Temp
            // 
            this.TextR25Temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextR25Temp.Location = new System.Drawing.Point(301, 99);
            this.TextR25Temp.Name = "TextR25Temp";
            this.TextR25Temp.ReadOnly = true;
            this.TextR25Temp.Size = new System.Drawing.Size(145, 21);
            this.TextR25Temp.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(149, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Temperature";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextR25Res
            // 
            this.TextR25Res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextR25Res.Location = new System.Drawing.Point(301, 72);
            this.TextR25Res.Name = "TextR25Res";
            this.TextR25Res.Size = new System.Drawing.Size(145, 21);
            this.TextR25Res.TabIndex = 8;
            this.TextR25Res.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextRTRes_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(149, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resistance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.tableLayoutPanel1.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(149, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "RT @ room temperature";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextRTMinTemp
            // 
            this.TextRTMinTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRTMinTemp.Location = new System.Drawing.Point(301, 45);
            this.TextRTMinTemp.Name = "TextRTMinTemp";
            this.TextRTMinTemp.Size = new System.Drawing.Size(145, 21);
            this.TextRTMinTemp.TabIndex = 5;
            this.TextRTMinTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextRTTemp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(149, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperature";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblResInfo
            // 
            this.LblResInfo.AutoSize = true;
            this.LblResInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.LblResInfo, 3);
            this.LblResInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResInfo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblResInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblResInfo.Location = new System.Drawing.Point(0, 0);
            this.LblResInfo.Margin = new System.Windows.Forms.Padding(0);
            this.LblResInfo.Name = "LblResInfo";
            this.LblResInfo.Size = new System.Drawing.Size(449, 15);
            this.LblResInfo.TabIndex = 0;
            this.LblResInfo.Text = "NTC Information";
            this.LblResInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(149, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "RT Minimum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(149, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resistance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextRTMinRes
            // 
            this.TextRTMinRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRTMinRes.Location = new System.Drawing.Point(301, 18);
            this.TextRTMinRes.Name = "TextRTMinRes";
            this.TextRTMinRes.Size = new System.Drawing.Size(145, 21);
            this.TextRTMinRes.TabIndex = 4;
            this.TextRTMinRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextRTRes_KeyPress);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonOk.Location = new System.Drawing.Point(152, 207);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(143, 30);
            this.ButtonOk.TabIndex = 16;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCancel.Location = new System.Drawing.Point(301, 207);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(145, 30);
            this.ButtonCancel.TabIndex = 17;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(3, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tolerance";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NTCParamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(449, 240);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NTCParamDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NTCParamDialog";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblResInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextRTMinRes;
        private System.Windows.Forms.TextBox TextRTMinTemp;
        private System.Windows.Forms.TextBox TextR25Temp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextR25Res;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextRTMaxTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextRTMaxRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextTolerance;
    }
}