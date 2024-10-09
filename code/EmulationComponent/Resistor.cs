using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTC_Emulator.EmulationComponent
{
    public class Resistor
    {
        private double _resistance;
        private double _maxResistance;
        private double _minResistance;
        private double _tolerance;
        public double Resistance
        {
            get
            {
                return _resistance;
            }
            set
            {
                _resistance = value;
                Update();
            }
        }
        public double Tolerance
        {
            get
            {
                return _tolerance;
            }
            set
            {
                _tolerance = value;
                Update();
            }
        }
        public double Minimum
        {
            get { return _minResistance; }
        }
        public double Maximum
        {
            get { return _maxResistance; }
        }
        public static Resistor operator +(Resistor left, Resistor right)
        {
            double nominal = left.Resistance + right.Resistance;
            double minimum = left.Minimum + right.Minimum;
            double maximum = left.Maximum + right.Maximum;
            double tolerance = 100.0 - (minimum / nominal * 100.0);
            return new Resistor(nominal, tolerance);
        }
        public static Resistor operator ^(Resistor left, Resistor right)
        {
            double nominal = 1.0 / ((1.0 / left.Resistance) + (1.0 / right.Resistance));
            double minimum = 1.0 / ((1.0 / left.Minimum) + (1.0 / right.Minimum));
            double maximum = 1.0 / ((1.0 / left.Maximum) + (1.0 / right.Maximum));
            double tolerance = 100.0 - (minimum / nominal * 100.0);
            return new Resistor(nominal, tolerance);
        }
        public Resistor()
        {
            _resistance = 10000;
            _tolerance = 1.0;
            Update();
        }
        public Resistor(double resistance, double tolerance)
        {
            _resistance = resistance;
            _tolerance = tolerance;
            Update();
        }
        private void Update()
        {
            _minResistance = (_resistance - (_resistance * _tolerance / 100));
            _maxResistance = (_resistance + (_resistance * _tolerance / 100));
        }
    }
}
