using NTC_Emulator.EmulationComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NTC_Emulator.CodeGenComponent.CodeGenInfo;

namespace NTC_Emulator.CodeGenComponent
{
    public abstract class FileContents
    {
        protected CodeGenInfo Info;
        public FileContents(CodeGenInfo info) { Info = info; }
        public abstract string GetHeaderFileContents();
        public abstract string GetSourceFileContents();
        protected string GetDataType()
        {
            string ret = "double";
            if (Info.CodeFloatType == FloatingDataType.FLOAT)
            {
                ret = "float";
            }

            return ret;
        }
        protected string GetUpperFileName()
        {
            return Info.FileName.ToUpper();
        }
        protected int GetTableLength()
        {
            int ret = 0;
            int start, end;
            switch (Info.IndexPerTempStep)
            {
                case IndexPerTemperature.FullStep:
                    ret = GetFullstepTableLength();
                    break;
                case IndexPerTemperature.IndexPer5:
                    if (Info.StartTemperature.GetTemperature(Info.Units) % 5 != 0)
                    {
                        start = (int)(Info.StartTemperature.GetTemperature(Info.Units) / 10) * 10 - 5;
                    }
                    else
                    {
                        start = (int)Info.StartTemperature.GetTemperature(Info.Units);
                    }
                    if (Info.EndTemperature.GetTemperature(Info.Units) % 5 != 0)
                    {
                        end = (int)(Info.EndTemperature.GetTemperature(Info.Units) / 10) * 10 + 5;
                    }
                    else
                    {
                        end = (int)Info.EndTemperature.GetTemperature(Info.Units);
                    }
                    ret = (end - start) / 5;
                    break;
                case IndexPerTemperature.IndexPer10:
                    if (Info.StartTemperature.GetTemperature(Info.Units) % 10 != 0)
                    {
                        start = (int)(Info.StartTemperature.GetTemperature(Info.Units) / 10) * 10 - 10;
                    }
                    else
                    {
                        start = (int)Info.StartTemperature.GetTemperature(Info.Units);
                    }
                    if (Info.EndTemperature.GetTemperature(Info.Units) % 10 != 0)
                    {
                        end = (int)(Info.EndTemperature.GetTemperature(Info.Units) / 10) * 10 + 10;
                    }
                    else
                    {
                        end = (int)Info.EndTemperature.GetTemperature(Info.Units);
                    }
                    ret = (end - start) / 10;
                    break;
            }
            return ret;
        }
        private int GetFullstepTableLength()
        {
            int ret = 0;
            int start_adc = Info.GetExpectedAdcOfNtc(Info.StartTemperature);
            int end_adc = Info.GetExpectedAdcOfNtc(Info.EndTemperature);
            ret = end_adc - start_adc;
            return ret;
        }
        protected int R25_Adc()
        {
            int ret = 0;
            Temperature temperature = new Temperature();
            temperature.Celsius = 25;
            ret = Info.GetExpectedAdcOfNtc(temperature);
            return ret;
        }
    }
}
