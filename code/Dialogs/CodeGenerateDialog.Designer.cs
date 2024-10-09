namespace NTC_Emulator.Dialogs
{
    partial class CodeGenerateDialog
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
            this.GroupAdcConfig = new System.Windows.Forms.GroupBox();
            this.TextVRef = new System.Windows.Forms.TextBox();
            this.ComboResolution = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupLanguage = new System.Windows.Forms.GroupBox();
            this.RadioLanguageCPP = new System.Windows.Forms.RadioButton();
            this.RadioLanguageC = new System.Windows.Forms.RadioButton();
            this.GroupOutputConfig = new System.Windows.Forms.GroupBox();
            this.GroupExpression = new System.Windows.Forms.GroupBox();
            this.ComboFloatDataType = new System.Windows.Forms.ComboBox();
            this.LabelFloatDataType = new System.Windows.Forms.Label();
            this.GroupTableConfig = new System.Windows.Forms.GroupBox();
            this.TextEndTemperature = new System.Windows.Forms.NumericUpDown();
            this.TextStartTemperature = new System.Windows.Forms.NumericUpDown();
            this.CheckIgnore = new System.Windows.Forms.CheckBox();
            this.StepTempUnit = new System.Windows.Forms.Label();
            this.LabelEndTempUnit = new System.Windows.Forms.Label();
            this.LabelStartTempUnit = new System.Windows.Forms.Label();
            this.ComboTableStep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupOutputType = new System.Windows.Forms.GroupBox();
            this.RadioTable = new System.Windows.Forms.RadioButton();
            this.RadioFormula = new System.Windows.Forms.RadioButton();
            this.GroupFile = new System.Windows.Forms.GroupBox();
            this.ButtonSelectPath = new System.Windows.Forms.Button();
            this.TextFileName = new System.Windows.Forms.TextBox();
            this.TextPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupResultLog = new System.Windows.Forms.GroupBox();
            this.ResultLog = new System.Windows.Forms.RichTextBox();
            this.GroupAdcConfig.SuspendLayout();
            this.GroupLanguage.SuspendLayout();
            this.GroupOutputConfig.SuspendLayout();
            this.GroupExpression.SuspendLayout();
            this.GroupTableConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEndTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextStartTemperature)).BeginInit();
            this.GroupOutputType.SuspendLayout();
            this.GroupFile.SuspendLayout();
            this.GroupResultLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupAdcConfig
            // 
            this.GroupAdcConfig.Controls.Add(this.TextVRef);
            this.GroupAdcConfig.Controls.Add(this.ComboResolution);
            this.GroupAdcConfig.Controls.Add(this.label11);
            this.GroupAdcConfig.Controls.Add(this.label10);
            this.GroupAdcConfig.Controls.Add(this.label5);
            this.GroupAdcConfig.Controls.Add(this.label1);
            this.GroupAdcConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupAdcConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupAdcConfig.Location = new System.Drawing.Point(0, 0);
            this.GroupAdcConfig.Name = "GroupAdcConfig";
            this.GroupAdcConfig.Size = new System.Drawing.Size(346, 39);
            this.GroupAdcConfig.TabIndex = 0;
            this.GroupAdcConfig.TabStop = false;
            this.GroupAdcConfig.Text = "ADC Configuration";
            // 
            // TextVRef
            // 
            this.TextVRef.Location = new System.Drawing.Point(249, 14);
            this.TextVRef.Name = "TextVRef";
            this.TextVRef.Size = new System.Drawing.Size(75, 21);
            this.TextVRef.TabIndex = 2;
            this.TextVRef.Text = "3.3";
            this.TextVRef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextVRef_KeyPress);
            // 
            // ComboResolution
            // 
            this.ComboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboResolution.FormattingEnabled = true;
            this.ComboResolution.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.ComboResolution.Location = new System.Drawing.Point(80, 14);
            this.ComboResolution.Name = "ComboResolution";
            this.ComboResolution.Size = new System.Drawing.Size(41, 20);
            this.ComboResolution.TabIndex = 1;
            this.ComboResolution.SelectedIndexChanged += new System.EventHandler(this.ComboResolution_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(327, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "V";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(216, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Vref";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(127, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bits";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupLanguage
            // 
            this.GroupLanguage.Controls.Add(this.RadioLanguageCPP);
            this.GroupLanguage.Controls.Add(this.RadioLanguageC);
            this.GroupLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupLanguage.Location = new System.Drawing.Point(0, 39);
            this.GroupLanguage.Name = "GroupLanguage";
            this.GroupLanguage.Size = new System.Drawing.Size(346, 47);
            this.GroupLanguage.TabIndex = 2;
            this.GroupLanguage.TabStop = false;
            this.GroupLanguage.Text = "Code Language";
            // 
            // RadioLanguageCPP
            // 
            this.RadioLanguageCPP.AutoSize = true;
            this.RadioLanguageCPP.ForeColor = System.Drawing.SystemColors.Control;
            this.RadioLanguageCPP.Location = new System.Drawing.Point(50, 20);
            this.RadioLanguageCPP.Name = "RadioLanguageCPP";
            this.RadioLanguageCPP.Size = new System.Drawing.Size(44, 16);
            this.RadioLanguageCPP.TabIndex = 0;
            this.RadioLanguageCPP.TabStop = true;
            this.RadioLanguageCPP.Text = "C++";
            this.RadioLanguageCPP.UseVisualStyleBackColor = true;
            this.RadioLanguageCPP.CheckedChanged += new System.EventHandler(this.RadioLanguageC_CheckedChanged);
            // 
            // RadioLanguageC
            // 
            this.RadioLanguageC.AutoSize = true;
            this.RadioLanguageC.ForeColor = System.Drawing.SystemColors.Control;
            this.RadioLanguageC.Location = new System.Drawing.Point(12, 20);
            this.RadioLanguageC.Name = "RadioLanguageC";
            this.RadioLanguageC.Size = new System.Drawing.Size(32, 16);
            this.RadioLanguageC.TabIndex = 0;
            this.RadioLanguageC.TabStop = true;
            this.RadioLanguageC.Text = "C";
            this.RadioLanguageC.UseVisualStyleBackColor = true;
            this.RadioLanguageC.CheckedChanged += new System.EventHandler(this.RadioLanguageC_CheckedChanged);
            // 
            // GroupOutputConfig
            // 
            this.GroupOutputConfig.Controls.Add(this.GroupExpression);
            this.GroupOutputConfig.Controls.Add(this.GroupTableConfig);
            this.GroupOutputConfig.Controls.Add(this.GroupOutputType);
            this.GroupOutputConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupOutputConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupOutputConfig.Location = new System.Drawing.Point(0, 86);
            this.GroupOutputConfig.Name = "GroupOutputConfig";
            this.GroupOutputConfig.Size = new System.Drawing.Size(346, 176);
            this.GroupOutputConfig.TabIndex = 3;
            this.GroupOutputConfig.TabStop = false;
            this.GroupOutputConfig.Text = "Output Configuration";
            // 
            // GroupExpression
            // 
            this.GroupExpression.Controls.Add(this.ComboFloatDataType);
            this.GroupExpression.Controls.Add(this.LabelFloatDataType);
            this.GroupExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupExpression.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupExpression.Location = new System.Drawing.Point(3, 131);
            this.GroupExpression.Name = "GroupExpression";
            this.GroupExpression.Size = new System.Drawing.Size(340, 42);
            this.GroupExpression.TabIndex = 2;
            this.GroupExpression.TabStop = false;
            this.GroupExpression.Text = "Expression Format";
            // 
            // ComboFloatDataType
            // 
            this.ComboFloatDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFloatDataType.FormattingEnabled = true;
            this.ComboFloatDataType.Items.AddRange(new object[] {
            "float",
            "double"});
            this.ComboFloatDataType.Location = new System.Drawing.Point(75, 14);
            this.ComboFloatDataType.Name = "ComboFloatDataType";
            this.ComboFloatDataType.Size = new System.Drawing.Size(63, 20);
            this.ComboFloatDataType.TabIndex = 2;
            this.ComboFloatDataType.SelectedIndexChanged += new System.EventHandler(this.ComboFloatDataType_SelectedIndexChanged);
            // 
            // LabelFloatDataType
            // 
            this.LabelFloatDataType.AutoSize = true;
            this.LabelFloatDataType.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelFloatDataType.Location = new System.Drawing.Point(7, 17);
            this.LabelFloatDataType.Name = "LabelFloatDataType";
            this.LabelFloatDataType.Size = new System.Drawing.Size(57, 12);
            this.LabelFloatDataType.TabIndex = 1;
            this.LabelFloatDataType.Text = "data type";
            // 
            // GroupTableConfig
            // 
            this.GroupTableConfig.Controls.Add(this.TextEndTemperature);
            this.GroupTableConfig.Controls.Add(this.TextStartTemperature);
            this.GroupTableConfig.Controls.Add(this.CheckIgnore);
            this.GroupTableConfig.Controls.Add(this.StepTempUnit);
            this.GroupTableConfig.Controls.Add(this.LabelEndTempUnit);
            this.GroupTableConfig.Controls.Add(this.LabelStartTempUnit);
            this.GroupTableConfig.Controls.Add(this.ComboTableStep);
            this.GroupTableConfig.Controls.Add(this.label4);
            this.GroupTableConfig.Controls.Add(this.label3);
            this.GroupTableConfig.Controls.Add(this.label2);
            this.GroupTableConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupTableConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupTableConfig.Location = new System.Drawing.Point(3, 64);
            this.GroupTableConfig.Name = "GroupTableConfig";
            this.GroupTableConfig.Size = new System.Drawing.Size(340, 67);
            this.GroupTableConfig.TabIndex = 1;
            this.GroupTableConfig.TabStop = false;
            this.GroupTableConfig.Text = "Table Configuration";
            // 
            // TextEndTemperature
            // 
            this.TextEndTemperature.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TextEndTemperature.Location = new System.Drawing.Point(77, 40);
            this.TextEndTemperature.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.TextEndTemperature.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.TextEndTemperature.Name = "TextEndTemperature";
            this.TextEndTemperature.Size = new System.Drawing.Size(62, 21);
            this.TextEndTemperature.TabIndex = 6;
            this.TextEndTemperature.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.TextEndTemperature.ValueChanged += new System.EventHandler(this.TextEndTemperature_ValueChanged);
            // 
            // TextStartTemperature
            // 
            this.TextStartTemperature.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TextStartTemperature.Location = new System.Drawing.Point(76, 13);
            this.TextStartTemperature.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.TextStartTemperature.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.TextStartTemperature.Name = "TextStartTemperature";
            this.TextStartTemperature.Size = new System.Drawing.Size(62, 21);
            this.TextStartTemperature.TabIndex = 6;
            this.TextStartTemperature.Value = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.TextStartTemperature.ValueChanged += new System.EventHandler(this.TextStartTemperature_ValueChanged);
            // 
            // CheckIgnore
            // 
            this.CheckIgnore.AutoSize = true;
            this.CheckIgnore.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckIgnore.Location = new System.Drawing.Point(185, 45);
            this.CheckIgnore.Name = "CheckIgnore";
            this.CheckIgnore.Size = new System.Drawing.Size(149, 16);
            this.CheckIgnore.TabIndex = 5;
            this.CheckIgnore.Text = "Ignore Vref over range";
            this.CheckIgnore.UseVisualStyleBackColor = true;
            this.CheckIgnore.CheckedChanged += new System.EventHandler(this.CheckIgnore_CheckedChanged);
            // 
            // StepTempUnit
            // 
            this.StepTempUnit.AutoSize = true;
            this.StepTempUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.StepTempUnit.Location = new System.Drawing.Point(320, 17);
            this.StepTempUnit.Name = "StepTempUnit";
            this.StepTempUnit.Size = new System.Drawing.Size(17, 12);
            this.StepTempUnit.TabIndex = 4;
            this.StepTempUnit.Text = "℃";
            // 
            // LabelEndTempUnit
            // 
            this.LabelEndTempUnit.AutoSize = true;
            this.LabelEndTempUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelEndTempUnit.Location = new System.Drawing.Point(139, 43);
            this.LabelEndTempUnit.Name = "LabelEndTempUnit";
            this.LabelEndTempUnit.Size = new System.Drawing.Size(17, 12);
            this.LabelEndTempUnit.TabIndex = 4;
            this.LabelEndTempUnit.Text = "℃";
            // 
            // LabelStartTempUnit
            // 
            this.LabelStartTempUnit.AutoSize = true;
            this.LabelStartTempUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelStartTempUnit.Location = new System.Drawing.Point(139, 17);
            this.LabelStartTempUnit.Name = "LabelStartTempUnit";
            this.LabelStartTempUnit.Size = new System.Drawing.Size(17, 12);
            this.LabelStartTempUnit.TabIndex = 4;
            this.LabelStartTempUnit.Text = "℃";
            // 
            // ComboTableStep
            // 
            this.ComboTableStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTableStep.FormattingEnabled = true;
            this.ComboTableStep.Items.AddRange(new object[] {
            "Full Step",
            "5",
            "10"});
            this.ComboTableStep.Location = new System.Drawing.Point(234, 14);
            this.ComboTableStep.Name = "ComboTableStep";
            this.ComboTableStep.Size = new System.Drawing.Size(80, 20);
            this.ComboTableStep.TabIndex = 3;
            this.ComboTableStep.SelectedIndexChanged += new System.EventHandler(this.ComboTableStep_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(162, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Table Step";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "End Temp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Temp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupOutputType
            // 
            this.GroupOutputType.Controls.Add(this.RadioTable);
            this.GroupOutputType.Controls.Add(this.RadioFormula);
            this.GroupOutputType.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupOutputType.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupOutputType.Location = new System.Drawing.Point(3, 17);
            this.GroupOutputType.Name = "GroupOutputType";
            this.GroupOutputType.Size = new System.Drawing.Size(340, 47);
            this.GroupOutputType.TabIndex = 0;
            this.GroupOutputType.TabStop = false;
            this.GroupOutputType.Text = "Output Type";
            // 
            // RadioTable
            // 
            this.RadioTable.AutoSize = true;
            this.RadioTable.ForeColor = System.Drawing.SystemColors.Control;
            this.RadioTable.Location = new System.Drawing.Point(84, 20);
            this.RadioTable.Name = "RadioTable";
            this.RadioTable.Size = new System.Drawing.Size(90, 16);
            this.RadioTable.TabIndex = 0;
            this.RadioTable.TabStop = true;
            this.RadioTable.Text = "Table Index";
            this.RadioTable.UseVisualStyleBackColor = true;
            this.RadioTable.CheckedChanged += new System.EventHandler(this.RadioFormula_CheckedChanged);
            // 
            // RadioFormula
            // 
            this.RadioFormula.AutoSize = true;
            this.RadioFormula.ForeColor = System.Drawing.SystemColors.Control;
            this.RadioFormula.Location = new System.Drawing.Point(9, 20);
            this.RadioFormula.Name = "RadioFormula";
            this.RadioFormula.Size = new System.Drawing.Size(69, 16);
            this.RadioFormula.TabIndex = 0;
            this.RadioFormula.TabStop = true;
            this.RadioFormula.Text = "Formula";
            this.RadioFormula.UseVisualStyleBackColor = true;
            this.RadioFormula.CheckedChanged += new System.EventHandler(this.RadioFormula_CheckedChanged);
            // 
            // GroupFile
            // 
            this.GroupFile.Controls.Add(this.ButtonSelectPath);
            this.GroupFile.Controls.Add(this.TextFileName);
            this.GroupFile.Controls.Add(this.TextPath);
            this.GroupFile.Controls.Add(this.label9);
            this.GroupFile.Controls.Add(this.label8);
            this.GroupFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupFile.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupFile.Location = new System.Drawing.Point(0, 262);
            this.GroupFile.Name = "GroupFile";
            this.GroupFile.Size = new System.Drawing.Size(346, 73);
            this.GroupFile.TabIndex = 4;
            this.GroupFile.TabStop = false;
            this.GroupFile.Text = "File";
            // 
            // ButtonSelectPath
            // 
            this.ButtonSelectPath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonSelectPath.Location = new System.Drawing.Point(289, 14);
            this.ButtonSelectPath.Name = "ButtonSelectPath";
            this.ButtonSelectPath.Size = new System.Drawing.Size(35, 21);
            this.ButtonSelectPath.TabIndex = 2;
            this.ButtonSelectPath.Text = "...";
            this.ButtonSelectPath.UseVisualStyleBackColor = true;
            this.ButtonSelectPath.Click += new System.EventHandler(this.ButtonSelectPath_Click);
            // 
            // TextFileName
            // 
            this.TextFileName.Location = new System.Drawing.Point(79, 41);
            this.TextFileName.MaxLength = 32;
            this.TextFileName.Name = "TextFileName";
            this.TextFileName.Size = new System.Drawing.Size(202, 21);
            this.TextFileName.TabIndex = 1;
            this.TextFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextFileName_KeyPress);
            // 
            // TextPath
            // 
            this.TextPath.Location = new System.Drawing.Point(46, 14);
            this.TextPath.Name = "TextPath";
            this.TextPath.ReadOnly = true;
            this.TextPath.Size = new System.Drawing.Size(235, 21);
            this.TextPath.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(10, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "File Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(10, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Path";
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(12, 542);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(104, 26);
            this.ButtonGenerate.TabIndex = 5;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(236, 542);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(104, 26);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Close";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // GroupResultLog
            // 
            this.GroupResultLog.Controls.Add(this.ResultLog);
            this.GroupResultLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupResultLog.ForeColor = System.Drawing.SystemColors.Control;
            this.GroupResultLog.Location = new System.Drawing.Point(0, 335);
            this.GroupResultLog.Name = "GroupResultLog";
            this.GroupResultLog.Size = new System.Drawing.Size(346, 201);
            this.GroupResultLog.TabIndex = 6;
            this.GroupResultLog.TabStop = false;
            this.GroupResultLog.Text = "Result Log";
            // 
            // ResultLog
            // 
            this.ResultLog.AutoWordSelection = true;
            this.ResultLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultLog.ForeColor = System.Drawing.SystemColors.Window;
            this.ResultLog.Location = new System.Drawing.Point(3, 17);
            this.ResultLog.Name = "ResultLog";
            this.ResultLog.ReadOnly = true;
            this.ResultLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ResultLog.Size = new System.Drawing.Size(340, 181);
            this.ResultLog.TabIndex = 0;
            this.ResultLog.Text = "";
            // 
            // CodeGenerateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(346, 572);
            this.ControlBox = false;
            this.Controls.Add(this.GroupResultLog);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.GroupFile);
            this.Controls.Add(this.GroupOutputConfig);
            this.Controls.Add(this.GroupLanguage);
            this.Controls.Add(this.GroupAdcConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeGenerateDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CodeGenerateDialog";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CodeGenerateDialog_Load);
            this.GroupAdcConfig.ResumeLayout(false);
            this.GroupAdcConfig.PerformLayout();
            this.GroupLanguage.ResumeLayout(false);
            this.GroupLanguage.PerformLayout();
            this.GroupOutputConfig.ResumeLayout(false);
            this.GroupExpression.ResumeLayout(false);
            this.GroupExpression.PerformLayout();
            this.GroupTableConfig.ResumeLayout(false);
            this.GroupTableConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEndTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextStartTemperature)).EndInit();
            this.GroupOutputType.ResumeLayout(false);
            this.GroupOutputType.PerformLayout();
            this.GroupFile.ResumeLayout(false);
            this.GroupFile.PerformLayout();
            this.GroupResultLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupAdcConfig;
        private System.Windows.Forms.ComboBox ComboResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupLanguage;
        private System.Windows.Forms.RadioButton RadioLanguageCPP;
        private System.Windows.Forms.RadioButton RadioLanguageC;
        private System.Windows.Forms.GroupBox GroupOutputConfig;
        private System.Windows.Forms.GroupBox GroupExpression;
        private System.Windows.Forms.ComboBox ComboFloatDataType;
        private System.Windows.Forms.Label LabelFloatDataType;
        private System.Windows.Forms.GroupBox GroupTableConfig;
        private System.Windows.Forms.Label StepTempUnit;
        private System.Windows.Forms.Label LabelEndTempUnit;
        private System.Windows.Forms.Label LabelStartTempUnit;
        private System.Windows.Forms.ComboBox ComboTableStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupOutputType;
        private System.Windows.Forms.RadioButton RadioTable;
        private System.Windows.Forms.RadioButton RadioFormula;
        private System.Windows.Forms.GroupBox GroupFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonSelectPath;
        private System.Windows.Forms.TextBox TextPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextFileName;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextVRef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CheckIgnore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupResultLog;
        private System.Windows.Forms.RichTextBox ResultLog;
        private System.Windows.Forms.NumericUpDown TextStartTemperature;
        private System.Windows.Forms.NumericUpDown TextEndTemperature;
    }
}