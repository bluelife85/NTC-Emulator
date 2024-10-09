using NTC_Emulator.CodeGenComponent;
using NTC_Emulator.EmulationComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NTC_Emulator.CodeGenComponent.CodeGenInfo;
namespace NTC_Emulator.Dialogs
{
    public partial class CodeGenerateDialog : Form
    {
        private EmulationInfo _EmulationInfo;
        private Temperature.Units _Unit;
        private Temperature _StartTemperature;
        private Temperature _EndTemperature;
        private CodeGenInfo _CodeGenInfo;

        public CodeGenerateDialog(EmulationInfo emulationInfo, Temperature.Units unit)
        {
            InitializeComponent();
            _EmulationInfo = emulationInfo;
            _Unit = unit;
            _StartTemperature = _EmulationInfo.MinimumRT.Temperature;
            _EndTemperature = _EmulationInfo.MaximumRT.Temperature;

            LabelStartTempUnit.Text = Temperature.GetDescription(_Unit);
            LabelEndTempUnit.Text = Temperature.GetDescription(_Unit);
            TextStartTemperature.Value = (decimal)_StartTemperature.GetTemperature(_Unit);
            TextEndTemperature.Value = (decimal)_EndTemperature.GetTemperature(_Unit);

            _CodeGenInfo = new CodeGenInfo(_EmulationInfo, new ADC(12, 3.3));
            TextStartTemperature.Minimum = (decimal)_EmulationInfo.MinimumRT.Temperature.GetTemperature(_Unit);
            TextStartTemperature.Maximum =
                (decimal) (_EmulationInfo.R25.Temperature.GetTemperature(_Unit) - 10);
            TextEndTemperature.Minimum =
                (decimal) (_EmulationInfo.R25.Temperature.GetTemperature(_Unit) + 10);
            TextEndTemperature.Maximum = (decimal)_EmulationInfo.MaximumRT.Temperature.GetTemperature(_Unit);
        }

        private void CodeGenerateDialog_Load(object sender, EventArgs e)
        {
            ComboResolution.SelectedIndex = 4;
            RadioLanguageC.Checked = true;
            RadioFormula.Checked = true;
            ComboTableStep.SelectedIndex = 0;
            ComboFloatDataType.SelectedIndex = 0;
            TextVRef.Text = "3.3";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] invalidChars = System.IO.Path.GetInvalidFileNameChars();

            if (invalidChars.Contains(e.KeyChar))
            {
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Space))
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void TextVRef_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void RadioLanguageC_CheckedChanged(object sender, EventArgs e)
        {
            int value =
            ((RadioLanguageC.Checked) ? (0x1) : (0)) |
            ((RadioLanguageCPP.Checked) ? (0x2) : (0));
            switch (value)
            {
                case 0x01:
                    _CodeGenInfo.Language = CodeLanguages.C;
                    break;
                case 0x02:
                    _CodeGenInfo.Language = CodeLanguages.CPP;
                    break;
            }
        }

        private void RadioFormula_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioFormula.Checked)
            {
                _CodeGenInfo.OutputFormatType = FormatType.EQUATION;
                GroupTableConfig.Enabled = false;
            }
            else if (RadioTable.Checked)
            {
                _CodeGenInfo.OutputFormatType = FormatType.TABLE;
                GroupTableConfig.Enabled = true;
            }
        }

        private void ComboTableStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboTableStep.SelectedIndex)
            {
                case 0:
                    _CodeGenInfo.IndexPerTempStep = IndexPerTemperature.FullStep;
                    break;
                case 1:
                    _CodeGenInfo.IndexPerTempStep = IndexPerTemperature.IndexPer5;
                    break;
                case 2:
                    _CodeGenInfo.IndexPerTempStep = IndexPerTemperature.IndexPer10;
                    break;
            }
        }

        private void CheckIgnore_CheckedChanged(object sender, EventArgs e)
        {
            _CodeGenInfo.IgnoreVrefRange = CheckIgnore.Checked;
        }

        private void ButtonSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (_CodeGenInfo.FolderPath != null)
            {
                dialog.SelectedPath = _CodeGenInfo.FolderPath;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _CodeGenInfo.FolderPath = dialog.SelectedPath;
                TextPath.Text = dialog.SelectedPath;
            }
        }

        private void ComboResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CodeGenInfo.AdcResolutionBit = ComboResolution.SelectedIndex + 8;
        }

        private void ComboFloatDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboFloatDataType.SelectedIndex)
            {
                case 0:
                    _CodeGenInfo.CodeFloatType = FloatingDataType.FLOAT;
                    break;
                case 1:
                    _CodeGenInfo.CodeFloatType = FloatingDataType.DOUBLE;
                    break;
            }
        }
        private void TextStartTemperature_ValueChanged(object sender, EventArgs e)
        {
            _StartTemperature.SetTemperature((double)TextStartTemperature.Value, _Unit);
        }

        private void TextEndTemperature_ValueChanged(object sender, EventArgs e)
        {
            _EndTemperature.SetTemperature((double)TextEndTemperature.Value, _Unit);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            string path_file;
            FileContents contents;

            double value;
            if (double.TryParse(TextPath.Text, out value))
                _CodeGenInfo.AdcReferenceVoltage = value;
            _CodeGenInfo.StartTemperature = _StartTemperature;
            _CodeGenInfo.EndTemperature = _EndTemperature;
            _CodeGenInfo.FileName = TextFileName.Text;
            // VerificationDialog dialog = new VerificationDialog(_CodeGenInfo._CircuitInfo);
            // dialog.ShowDialog();

            if (IsValid())
            {
                switch (_CodeGenInfo.Language)
                {
                    case CodeLanguages.C:
                        path_file = _CodeGenInfo.FolderPath + "/" + _CodeGenInfo.FileName + ".h";
                        contents = new C_FileContents(_CodeGenInfo);
                        File.WriteAllText(path_file, contents.GetHeaderFileContents());

                        path_file = _CodeGenInfo.FolderPath + "/" + _CodeGenInfo.FileName + ".c";
                        File.WriteAllText(path_file, contents.GetSourceFileContents());
                        break;
                    case CodeLanguages.CPP:
                        path_file = _CodeGenInfo.FolderPath + "/" + _CodeGenInfo.FileName + ".h";
                         contents = new CPP_FileContents(_CodeGenInfo);
                        File.WriteAllText(path_file, contents.GetHeaderFileContents());

                        path_file = _CodeGenInfo.FolderPath + "/" + _CodeGenInfo.FileName + ".cpp";
                        File.WriteAllText(path_file, contents.GetSourceFileContents());
                        break;
                }
            }
            else
            {
            }
        }

        private bool IsValid()
        {
            string[] cKeywords = { "auto", "break", "case", "char", "const", "continue", "default", "do", "double", "else",
                               "enum", "extern", "float", "for", "goto", "if", "int", "long", "register", "return",
                               "short", "signed", "sizeof", "static", "struct", "switch", "typedef", "union", "unsigned",
                               "void", "volatile", "while" };
            char[] cSpecialCharacters = { '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '+',
                                          '[', ']', '{', '}', '\\', '|', ';', ':', '\'', '"', ',', '<', '.', '>', '/', '?'
                                        };
            NTC rt = _CodeGenInfo.NTC;
            StringBuilder sb = new StringBuilder();
            bool ret = true;
            ResultLog.ForeColor = Color.Red;

            #region Table setting validation
            if (_CodeGenInfo.OutputFormatType == FormatType.TABLE)
            {
                double step = 0;
                switch (_CodeGenInfo.IndexPerTempStep)
                {
                    case IndexPerTemperature.FullStep:
                        step = 0;
                        break;
                    case IndexPerTemperature.IndexPer5:
                        step = 5;
                        break;
                    case IndexPerTemperature.IndexPer10:
                        step = 10;
                        break;
                }

                if ((_CodeGenInfo.EndTemperature.Celsius - _CodeGenInfo.StartTemperature.Celsius) < step)
                {
                    sb.Append("ERROR > The difference between Start Temperature and End Temperature must be greater than the Table Step.\n");
                    ret = false;
                }
            }
            #endregion
            #region File validation
            if (string.IsNullOrEmpty(_CodeGenInfo.FolderPath))
            {
                sb.Append("ERROR > No path was specified to save the file.\n");
                ret = false;
            }

            if (string.IsNullOrEmpty(_CodeGenInfo.FileName))
            {
                sb.Append("ERROR > No file name was specified.\n");
                ret = false;
            }
            else
            {
                if (cKeywords.Contains(_CodeGenInfo.FileName))
                {
                    sb.Append("ERROR > Reserved words in the C language cannot be used as file names.\n");
                    ret = false;
                }

                if (char.IsDigit(_CodeGenInfo.FileName[0]))
                {
                    sb.Append("ERROR > File names must follow the rules for variable names.");
                    ret = false;
                }

                if (_CodeGenInfo.FileName.Length > 36)
                {
                    sb.Append("ERROR > File names cannot exceed 36 characters.\n");
                    ret = false;
                }

                for (int i = 0; i < _CodeGenInfo.FileName.Length; i++)
                {
                    if (cSpecialCharacters.Contains(_CodeGenInfo.FileName[i]))
                    {
                        sb.Append("ERROR > File names cannot contain special characters, except for underbars.\n");
                        ret = false;
                        break;
                    }
                }
            }
            #endregion
            if (ret)
            {
                ResultLog.ForeColor = SystemColors.WindowText;
                sb.Append("Success\n");
            }

            ResultLog.Text = sb.ToString();

            return ret;
        }
    }
}
