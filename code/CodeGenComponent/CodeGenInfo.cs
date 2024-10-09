using NTC_Emulator.EmulationComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTC_Emulator.CodeGenComponent
{
    public class CodeGenInfo
    {
        public EmulationInfo _EmulationInfo;
        private ADC _AdcCalculator;

        public CodeLanguages Language;
        public FormatType OutputFormatType;
        public int NbrOfDecimalPoint;
        public FloatingDataType CodeFloatType;
        public PullState NtcPullState;
        public Temperature.Units Units;
        public Temperature StartTemperature;
        public Temperature EndTemperature;
        public IndexPerTemperature IndexPerTempStep;
        public bool IgnoreVrefRange;
        public string FolderPath;
        public string FileName;
        public enum CodeLanguages
        {
            C,
            CPP,
        }
        public enum FormatType
        {
            EQUATION,
            TABLE
        }
        public enum FloatingDataType
        {
            FLOAT,
            DOUBLE
        }
        public enum PullState
        {
            Pullup,
            Pulldown
        }
        public enum IndexPerTemperature
        {
            FullStep,
            IndexPer5,
            IndexPer10
        }
        public int AdcResolutionBit
        {
            set { _AdcCalculator.Bits = value; }
            get { return _AdcCalculator.Bits; }
        }
        public int Resolution
        {
            get { return _AdcCalculator.Resolution; }
        }
        public double AdcReferenceVoltage
        {
            get { return _AdcCalculator.Vref; }
            set { _AdcCalculator.Vref = value; }
        }
        public double Vin
        {
            get { return _EmulationInfo.VIN; }
        }
        public double DivideResistance
        {
            get { return _EmulationInfo.Divider.Resistance; }
        }
        public double A
        {
            get { return _EmulationInfo.NTC.A; }
        }
        public double B
        {
            get { return _EmulationInfo.NTC.B; }
        }
        public double C
        {
            get { return _EmulationInfo.NTC.C; }
        }
        public NTC NTC
        {
            get { return _EmulationInfo.NTC; }
        }
        public CodeGenInfo(EmulationInfo emulationInfo, ADC adc)
        {
            _EmulationInfo = emulationInfo;
            _AdcCalculator = adc;

            Language = CodeLanguages.C;
            OutputFormatType = FormatType.EQUATION;
            CodeFloatType = FloatingDataType.FLOAT;
            NtcPullState = (_EmulationInfo.IsNTCPullup) ? (PullState.Pullup) : (PullState.Pulldown);
            NbrOfDecimalPoint = 0;
        }
        public int VoltageToAdc(double voltage)
        {
            return _AdcCalculator.VoltToAdc(voltage);
        }
        public double AdcToVoltage(int adc)
        {
            return _AdcCalculator.AdcToVolt(adc);
        }
        public double GetExpectedVout(double expectedNtcOhm)
        {
            return _EmulationInfo.GetExpectedVout(expectedNtcOhm);
        }
        public double GetExpectedNtcOhm(double expectedVout)
        {
            return _EmulationInfo.GetExpectedNtcOhm(expectedVout);
        }
        public Temperature GetExpectedNtcTemperature(double expectedVout)
        {
            return _EmulationInfo.GetExpectedNtcTemperature(expectedVout);
        }
        public Temperature GetExpectedNtcTemperature(int adc)
        {
            return _EmulationInfo.GetExpectedNtcTemperature(_AdcCalculator.AdcToVolt(adc));
        }
        public int GetExpectedAdcOfNtc(Temperature expectedTemperature)
        {
            double resistance = _EmulationInfo.NTC.ConvertToResistance(expectedTemperature);
            double vout = _EmulationInfo.GetExpectedVout(resistance);
            return _AdcCalculator.VoltToAdc(vout);
        }
    }
}
