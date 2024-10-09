using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTC_Emulator.EmulationComponent
{
    public class EmulationInfo
    {
        private double _Vin;
        private NTC _NTC;
        private Resistor _Divider;
        private bool IsNtcPullup;
        #region Properties
        public NTC NTC
        {
            set { _NTC = value; }
            get { return _NTC; }
        }
        public Resistor Divider
        {
            set { _Divider = value; }
            get { return _Divider; }
        }
        public double VIN
        {
            set { _Vin = value; }
            get { return _Vin; }
        }
        public bool IsNTCPullup
        {
            get { return IsNtcPullup; }
        }
        public RT MinimumRT
        {
            get { return _NTC.MinimumRT; }
        }
        public RT R25
        {
            get { return _NTC.R25; }
        }
        public RT MaximumRT
        {
            get { return _NTC.MaximumRT; }
        }
        #endregion
        public EmulationInfo(double vin, NTC ntc, Resistor divider, bool isNtcPullup)
        {
            _NTC = ntc;
            _Vin = vin;
            _Divider = divider;
            _NTC = ntc;
            IsNtcPullup = isNtcPullup;
        }
        public double GetExpectedVout(double expectedNtcOhm)
        {
            double ret = 0;
            if (IsNtcPullup)
            {
                ret = VIN * (Divider.Resistance / (expectedNtcOhm + Divider.Resistance));
            }
            else
            {
                ret = VIN * (expectedNtcOhm / (Divider.Resistance + expectedNtcOhm));
            }
            return ret;
        }
        public double GetExpectedVout(Temperature temperature)
        {
            return GetExpectedVout(_NTC.ConvertToResistance(temperature));
        }
        public double GetExpectedNtcOhm(double expectedVout)
        {
            double ret = 0;

            if (expectedVout > VIN)
                throw new Exception("Vout can't be greater than Vin.");

            if (IsNtcPullup)
            {
                ret = Divider.Resistance * ((VIN / expectedVout) - 1);
            }
            else
            {
                ret = (expectedVout * Divider.Resistance) / (VIN - expectedVout);
            }
            return ret;
        }
        public double GetExpectedNtcOhm(Temperature temperature)
        {
            return _NTC.ConvertToResistance(temperature);
        }
        public Temperature GetExpectedNtcTemperature(double expectedVout)
        {
            Temperature ret;

            if (expectedVout > _Vin)
                throw new Exception("Vout can't be greater than Vin.");
            ret = _NTC.ConvertToTemperature(GetExpectedNtcOhm(expectedVout));
            return ret;
        }
        public Temperature GetExpectedNtcTemperatureFromOhm(double expectedOhm)
        {
            return _NTC.ConvertToTemperature(expectedOhm);
        }
    }
}
