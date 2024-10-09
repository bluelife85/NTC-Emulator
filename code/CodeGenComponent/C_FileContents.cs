using NTC_Emulator.EmulationComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NTC_Emulator.CodeGenComponent.CodeGenInfo;

namespace NTC_Emulator.CodeGenComponent
{
    public class C_FileContents : FileContents
    {
        public C_FileContents(CodeGenInfo info) : base(info) { Info = info; }
        public override string GetHeaderFileContents()
        {
            StringBuilder sb = new StringBuilder();
            #region header file doxygen
            sb.AppendLine("/**");
            sb.AppendLine(" * @file " + Info.FileName + ".h");
            sb.AppendLine(" * @author NTC Emulation Generator").AppendLine(" * @brief This file is a module that calculates the temperature corresponding to the NTC for the input of the ADC.");
            sb.Append(" * @date ").AppendLine(DateTime.Now.ToString("yyyy-MM-dd"));
            sb.AppendLine(" */");
            #endregion
            #region start include block
            sb.AppendLine("#ifndef __NTC_" + GetUpperFileName() + "_H__");
            sb.AppendLine("#define __NTC_" + GetUpperFileName() + "_H__").AppendLine("");
            #endregion
            #region structure declaration
            sb.AppendLine("/**");
            sb.AppendLine(" * @struct " + Info.FileName);
            sb.AppendLine(" * @brief This is a structure for managing each NTC when using multiple identical parts in one project.");
            sb.AppendLine(" */");
            sb.AppendLine("struct " + Info.FileName).AppendLine("{");
            sb.AppendLine("    /**< ADC value when exposed to 25℃ */");
            sb.AppendLine("    int offset;");
            sb.AppendLine("    /**< Temperature data for the specified NTC object */");
            sb.AppendLine("    " + GetDataType() + " temperature;").AppendLine("};").AppendLine("");
            #endregion
            #region function prototype
            sb.AppendLine("/**");
            sb.AppendLine(" * @fn NTC_GetTemperature");
            sb.AppendLine(" * @param " + Info.FileName + " NTC object");
            sb.AppendLine(" * @param int adc value");
            sb.AppendLine(" * @return " + GetDataType() + " temperature value");
            sb.Append(" * @brief ");
            sb.AppendLine("Obtain temperature data of " + GetDataType() + " type using the adc value.");

            sb.AppendLine(" * @note The unit of temperature expressed in this function is " + Temperature.GetDescription(Info.Units) + ".");
            sb.AppendLine(" */");
            sb.AppendLine(GetDataType() + " NTC_GetTemperature(struct " + Info.FileName + "* obj, int adc);");
            sb.AppendLine("/**");
            sb.AppendLine(" * @fn NTC_SetOffset");
            sb.AppendLine(" * @param " + Info.FileName + " NTC object");
            sb.AppendLine(" * @param int adc value");
            sb.Append(" * @brief ");
            sb.AppendLine("Sets the offset of the ADC for 25℃ to the object.");

            sb.AppendLine(" * @note To use this function, the ADC must be performed in a chamber with an NTC of 25℃.");
            sb.AppendLine(" */");
            sb.AppendLine("void NTC_SetOffset(struct " + Info.FileName + "* obj, int adc);");
            sb.AppendLine("");
            #endregion
            #region end include block
            sb.AppendLine("#endif /* __NTC_{file_name}_H__ */\r\n");
            #endregion
            return sb.ToString();
        }
        public override string GetSourceFileContents()
        {
            StringBuilder sb = new StringBuilder();
            #region source file doxygen
            sb.AppendLine("/**");
            sb.AppendLine(" * @file " + Info.FileName + ".c");
            sb.AppendLine(" * @author NTC Emulation Generator").AppendLine(" * @brief This file is a module that calculates the temperature corresponding to the NTC for the input of the ADC.");
            sb.Append(" * @date ").AppendLine(DateTime.Now.ToString("yyyy-MM-dd"));
            sb.AppendLine(" */");
            #endregion
            #region include block
            sb.AppendLine("#include \"" + Info.FileName + ".h\"");
            #endregion
            if (Info.OutputFormatType == FormatType.EQUATION)
            {
                sb.AppendLine("#include \"math.h\"");
                sb.AppendLine("");
                #region define block
                #region define-coefficient block
                sb.Append("#define A (" + Info.A.ToString("0.000000000000"));
                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                {
                    sb.AppendLine("f)");
                }
                else
                {
                    sb.AppendLine(")");
                }
                sb.Append("#define B (" + Info.B.ToString("0.000000000000"));
                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                {
                    sb.AppendLine("f)");
                }
                else
                {
                    sb.AppendLine(")");
                }
                sb.Append("#define C (" + Info.C.ToString("0.000000000000"));
                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                {
                    sb.AppendLine("f)");
                }
                else
                {
                    sb.AppendLine(")");
                }
                #endregion
                #region define-divider resistance block
                sb.Append("#define DIVIDER (");
                sb.Append(Info.DivideResistance.ToString("0.000"));

                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                    sb.AppendLine("f)");
                else
                    sb.AppendLine(")");
                #endregion
                #region define-Vin block
                sb.Append("#define VIN (" + Info.Vin.ToString("0.000"));
                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                    sb.AppendLine("f)");
                else
                    sb.AppendLine(")");
                #endregion
                #region define-Vref block
                sb.Append("#define VREF (" + Info.Vin.ToString("0.000"));
                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                    sb.AppendLine("f)");
                else
                    sb.AppendLine(")");
                #endregion
                #region define-Adc-Full range
                sb.AppendLine("#define ADC_RESOLUTION ((" + GetDataType() + ") " + Info.Resolution.ToString() + ")");
                #endregion
                #region define-R25 Adc
                sb.AppendLine("#define R25_ADC ((" + GetDataType() + ") " + R25_Adc() + ")");
                #endregion
                #endregion
                sb.AppendLine("");
                #region local function prototype block
                sb.AppendLine("static " + GetDataType() + " NTC_GetResistance(struct " + Info.FileName + "* obj, int adc);");
                #endregion
                sb.AppendLine("");
                #region global function implementation block
                sb.AppendLine(GetDataType() + " NTC_GetTemperature(struct " + Info.FileName + "* obj, int adc)").AppendLine("{");
                sb.AppendLine("    " + GetDataType() + " lnR = log(NTC_GetResistance(obj, adc));");
                sb.AppendLine("    " + GetDataType() + " kelvin;");
                sb.AppendLine("    kelvin = 1.0 / (A + (B * lnR) + (C * (lnR * lnR * lnR)));");
                switch (Info.Units)
                {
                    case Temperature.Units.Celsius:
                        sb.Append("    obj->temperature = kelvin - 273.15");
                        if (Info.CodeFloatType == FloatingDataType.FLOAT)
                            sb.Append("f");
                        sb.AppendLine(";");
                        break;
                    case Temperature.Units.Fahrenheit:
                        sb.Append("    obj->temperature = ((kelvin - 273.15");
                        if (Info.CodeFloatType == FloatingDataType.FLOAT)
                            sb.Append("f");
                        sb.Append(") * 9.0");
                        if (Info.CodeFloatType == FloatingDataType.FLOAT)
                            sb.Append("f");
                        sb.Append(" / 5.0");
                        if (Info.CodeFloatType == FloatingDataType.FLOAT)
                            sb.Append("f");
                        sb.Append(") + 32.0");
                        if (Info.CodeFloatType == FloatingDataType.FLOAT)
                            sb.Append("f");
                        sb.AppendLine(";");
                        break;
                    default:
                        sb.AppendLine("    obj->temperature = kelvin;");
                        break;
                }
                sb.AppendLine("    return obj->temperature;").AppendLine("}");

                sb.AppendLine("void NTC_SetOffset(struct " + Info.FileName + "* obj, int adc)");
                sb.AppendLine("{");
                sb.AppendLine("    obj->offset = R25_ADC - adc;");
                sb.AppendLine("}");
                #endregion
                sb.AppendLine("");
                #region NTC_GetResistance function implementation block
                sb.AppendLine("static " + GetDataType() + " NTC_GetResistance(struct " + Info.FileName + "* obj, int adc)").AppendLine("{");
                sb.AppendLine("    " + GetDataType() + " vout = ((" + GetDataType() + ") (adc - obj->offset)) / ADC_RESOLUTION * VREF;");
                if (Info.NtcPullState == PullState.Pullup)
                    sb.AppendLine("    " + GetDataType() + " ret = DIVIDER * ((VIN / vout) - 1);");
                else
                    sb.AppendLine("    " + GetDataType() + " ret = (DIVIDER * vout) / (VIN - vout);");
                sb.AppendLine("    return ret;").AppendLine("}").AppendLine("");
                #endregion
            }
            else
            {
                sb.AppendLine("");
                #region initialize table block
                double[] table;
                int lineLength;
                double increseStep;
                Temperature tempObj;

                if (Info.IndexPerTempStep == IndexPerTemperature.IndexPer5)
                    increseStep = 5;
                else
                    increseStep = 10;

                if (Info.IndexPerTempStep == IndexPerTemperature.FullStep)
                {
                    table = new double[GetTableLength()];
                    lineLength = GetTableLength();
                    for (int i = 0; i < lineLength; i++)
                    {
                        int expectedAdc = Info.GetExpectedAdcOfNtc(Info.StartTemperature) + i;
                        tempObj = Info.GetExpectedNtcTemperature(expectedAdc);
                        switch (Info.Units)
                        {
                            case Temperature.Units.Fahrenheit:
                                table[i] = tempObj.Fahrenheit;
                                break;
                            case Temperature.Units.Kelvin:
                                table[i] = tempObj.Kelvin;
                                break;
                            default:
                                table[i] = tempObj.Celsius;
                                break;
                        }
                    }
                }
                else
                {
                    tempObj = new Temperature(Info.StartTemperature.Kelvin);
                    lineLength = GetTableLength();
                    table = new double[lineLength];

                    for (int i = 0; i < lineLength; i++)
                    {
                        table[i] = Info.GetExpectedAdcOfNtc(tempObj);
                        switch (Info.Units)
                        {
                            case Temperature.Units.Fahrenheit:
                                tempObj.Fahrenheit += increseStep;
                                break;
                            case Temperature.Units.Kelvin:
                                tempObj.Kelvin += increseStep;
                                break;
                            default:
                                tempObj.Celsius += increseStep;
                                break;
                        }
                    }
                }
                #endregion
                #region define block
                sb.Append("#define OVER_RANGE (-512.0");
                if (Info.CodeFloatType == FloatingDataType.FLOAT)
                    sb.Append("f");
                sb.AppendLine(")");
                sb.AppendLine("#define R25_ADC ((" + GetDataType() + ") " + R25_Adc() + ")");
                if (Info.IndexPerTempStep == IndexPerTemperature.FullStep)
                    sb.AppendLine("#define TABLE_ADC_OFFSET (" + Info.GetExpectedAdcOfNtc(Info.StartTemperature) + ")");
                else
                {
                    sb.AppendLine("#define NBR_OF_TABLE (" + table.Length + "u)");
                    sb.AppendLine("#define START_TEMPERATURE ((" + GetDataType() + ") " + ((int)Info.StartTemperature.GetTemperature(Info.Units)).ToString() + ")");
                    sb.AppendLine("#define TEMPERATURE_STEP ((" + GetDataType() + ") " + ((int)increseStep).ToString() + ")");
                    sb.AppendLine("#define MIDDLE_INDEX (" + table.Length / 2 + "u)");
                }
                sb.AppendLine("");
                #endregion
                #region create table block
                sb.AppendLine("/**");
                sb.AppendLine(" * @brief The temperature unit in this table is " + Temperature.GetDescription(Info.Units) + ".");
                sb.AppendLine(" */");
                sb.AppendLine("const " + GetDataType() + " NTC_Table[NBR_OF_TABLE] = ").AppendLine("{");
                if (Info.IndexPerTempStep == IndexPerTemperature.FullStep)
                {
                    sb.Append("    ");
                    for (int i = 0; i < table.Length; i++)
                    {
                        if (i != 0 && i % 10 == 0)
                        {
                            sb.AppendLine("");
                            sb.Append("    ");
                        }

                        sb.Append(table[i].ToString("F3").PadLeft(8, ' '));
                        if (i < (table.Length - 1))
                            sb.Append(",");
                    }
                }
                else
                {
                    int padSize = 8;
                    switch (Info.AdcResolutionBit)
                    {
                        case 8:
                        case 9:
                            padSize = 3;
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            padSize = 4;
                            break;
                        case 14:
                        case 15:
                        case 16:
                            padSize = 5;
                            break;
                        case 17:
                        case 18:
                        case 19:
                            padSize = 6;
                            break;
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                            padSize = 7;
                            break;
                        default:
                            padSize = 8;
                            break;
                    }
                    int start_temp = (int)Info.StartTemperature.GetTemperature(Info.Units);
                    int step = (Info.IndexPerTempStep == IndexPerTemperature.IndexPer5) ? 5 : 10;
                    int j = 0, k = 0;
                    int loop;

                    for (int i = 0; i < table.Length; i++)
                    {
                        if (i != 0 && i % 10 == 0)
                        {
                            sb.AppendLine("");
                            sb.Append("//");
                            if ((table.Length - (k * 10)) / 10 > 0)
                                loop = 10;
                            else
                                loop = table.Length % 10;

                            for (j = 0; j < loop; j++, k++)
                            {
                                sb.Append((start_temp + (step * k)).ToString().PadLeft(padSize + 2, ' '));
                            }
                            sb.AppendLine("");
                            sb.Append("    ");
                        }
                        else if (i % 10 == 0)
                        {
                            sb.Append("//");
                            if (table.Length / 10 > 0)
                                loop = 10;
                            else
                                loop = table.Length;
                            for (j = 0; j < loop; j++, k++)
                            {
                                sb.Append((start_temp + (step * k)).ToString().PadLeft(padSize + 2, ' '));
                            }
                            sb.AppendLine("").Append("    ");
                        }

                        sb.Append(((int)table[i]).ToString().PadLeft(padSize, ' '));
                        if (i < (table.Length - 1))
                            sb.Append(", ");
                    }
                }

                sb.AppendLine("").AppendLine("};").AppendLine("");
                #endregion
                #region global function implementaion block
                sb.AppendLine(GetDataType() + " NTC_GetTemperature(struct " + Info.FileName + "* obj, int adc)").AppendLine("{");
                switch (Info.IndexPerTempStep)
                {
                    case IndexPerTemperature.FullStep:
                        sb.AppendLine("    " + GetDataType() + " ret = OVER_RANGE;").AppendLine("");
                        sb.AppendLine("    adc -= obj->offset;");
                        sb.AppendLine("    if(adc >= TABLE_ADC_OFFSET)");
                        sb.AppendLine("    {");
                        sb.AppendLine("        adc -= TABLE_ADC_OFFSET;");
                        sb.AppendLine("        ret = NTC_Table[adc];");
                        sb.AppendLine("    }");
                        sb.AppendLine("    obj->temperature = ret;");
                        sb.AppendLine("    return ret;");
                        break;
                    case IndexPerTemperature.IndexPer5:
                    case IndexPerTemperature.IndexPer10:
                        sb.AppendLine("    " + GetDataType() + " ret = OVER_RANGE;");
                        sb.AppendLine("    int index = 0;");
                        sb.AppendLine("    " + GetDataType() + " temp_slope;").AppendLine("");
                        sb.AppendLine("    if ((adc >= (int) NTC_Table[0]) &&");
                        sb.AppendLine("        (adc <= (int) NTC_Table[NBR_OF_TABLE-1]))");
                        sb.AppendLine("    {");
                        sb.AppendLine("        if(adc < (int) NTC_Table[MIDDLE_INDEX])");
                        sb.AppendLine("            index = MIDDLE_INDEX;");
                        sb.AppendLine("        else");
                        sb.AppendLine("            index = NBR_OF_TABLE - 1;");
                        sb.AppendLine("        do");
                        sb.AppendLine("        {");
                        sb.AppendLine("            if(adc <= (int) NTC_Table[index] && adc >= NTC_Table[index - 1])");
                        sb.AppendLine("                break;");
                        sb.AppendLine("            else");
                        sb.AppendLine("                index--;");
                        sb.AppendLine("        } while (index != 1);");
                        sb.AppendLine("        temp_slope = TEMPERATURE_STEP / (NTC_Table[index] - NTC_Table[index - 1]);");
                        sb.AppendLine("        ret = (START_TEMPERATURE + ((index -1 ) * TEMPERATURE_STEP)) + ((adc - NTC_Table[index - 1]) * temp_slope);");
                        sb.AppendLine("    }");
                        sb.AppendLine("    obj->temperature = ret;");
                        sb.AppendLine("    return ret;");
                        break;
                }
                sb.AppendLine("}");
                sb.AppendLine("void NTC_SetOffset(struct " + Info.FileName + "* obj, int adc)");
                sb.AppendLine("{");
                sb.AppendLine("    obj->offset = R25_ADC - adc;");
                sb.AppendLine("}");
                sb.AppendLine("");
                #endregion
            }
            return sb.ToString();
        }
    }
}
