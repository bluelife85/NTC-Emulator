namespace NTC_Emulator.EmulationComponent
{
    public class ADC
    {
        private int _ResolutionBits;
        private int _Resolution;
        private double _Vref;

        public int Resolution
        {
            get { return _Resolution; }
        }
        public int Bits
        {
            get { return _ResolutionBits; }
            set
            {
                _ResolutionBits = value;
                _Resolution = 1 << _ResolutionBits;
            }
        }
        public double Vref
        {
            get { return _Vref; }
            set { _Vref = value; }
        }
        public ADC(int bits, double vref)
        {
            Bits = bits;
            _Vref = vref;
        }
        public int VoltToAdc(double voltage)
        {
            return (int)((voltage / _Vref) * _Resolution);
        }
        public double AdcToVolt(int adc)
        {
            return (adc / Resolution) * Vref;
        }
    }
}
