using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTC_Emulator.EmulationComponent
{
    public class RT
    {
        private Temperature _Temperature;
        private Resistor _Resistor;
        public Temperature Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        public Resistor Resistor
        {
            get { return _Resistor; }
            set { _Resistor = value; }
        }
        public double Resistance
        {
            get { return _Resistor.Resistance; }
        }
        public static RT operator +(RT left, Resistor right)
        {
            double nominal = left.Resistor.Resistance + right.Resistance;
            double minimum = left.Resistor.Minimum + right.Minimum;
            double maximum = left.Resistor.Maximum + right.Maximum;
            double tolerance = 100.0 - (minimum / nominal * 100.0);
            return new RT(nominal, left.Temperature.Celsius, tolerance);
        }
        public static RT operator ^(RT left, Resistor right)
        {
            double nominal = 1.0 / ((1.0 / left.Resistor.Resistance) + (1.0 / right.Resistance));
            double minimum = 1.0 / ((1.0 / left.Resistor.Minimum) + (1.0 / right.Minimum));
            double maximum = 1.0 / ((1.0 / left.Resistor.Maximum) + (1.0 / right.Maximum));
            double tolerance = 100.0 - (minimum / nominal * 100.0);

            return new RT(nominal, left.Temperature.Celsius, tolerance);
        }
        public RT()
        {
            _Resistor = new Resistor();
            _Temperature = new Temperature();
        }
        public RT(double resistance, double celsius, double tolerance)
        {
            _Resistor = new Resistor(resistance, tolerance);
            _Temperature = new Temperature();
            _Temperature.Celsius = celsius;
        }
    }
}
