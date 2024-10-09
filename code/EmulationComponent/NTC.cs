using System;

namespace NTC_Emulator.EmulationComponent
{
    public class NTC
    {
        private RT[] _RT;
        private double[] L;
        private double[] Y;
        private double[] Gamma;
        private double _A;
        private double _B;
        private double _C;
        #region Properties
        public double Tolerance
        {
            get
            {
                return _RT[1].Resistor.Tolerance;
            }
            set
            {
                foreach (RT element in _RT)
                {
                    element.Resistor.Tolerance = value;
                }
                CalculateCoefficients();
            }
        }
        public RT MinimumRT
        {
            get { return _RT[0]; }
            set
            {
                _RT[0].Resistor = value.Resistor;
                _RT[0].Temperature = value.Temperature;
                foreach (RT element in _RT)
                {
                    element.Resistor.Tolerance = value.Resistor.Tolerance;
                }
                CalculateCoefficients();
            }
        }
        public RT R25
        {
            get { return _RT[1]; }
            set
            {
                _RT[1].Resistor = value.Resistor;
                _RT[1].Temperature = value.Temperature;
                foreach (RT element in _RT)
                {
                    element.Resistor.Tolerance = value.Resistor.Tolerance;
                }
                CalculateCoefficients();
            }
        }
        public RT MaximumRT
        {
            get { return _RT[2]; }
            set
            {
                _RT[2].Resistor = value.Resistor;
                _RT[2].Temperature = value.Temperature;
                foreach (RT element in _RT)
                {
                    element.Resistor.Tolerance = value.Resistor.Tolerance;
                }
                CalculateCoefficients();
            }
        }
        public double A
        {
            get { return _A; }
        }
        public double B
        {
            get { return _B; }
        }
        public double C
        {
            get { return _C; }
        }
        #endregion
        public NTC()
        {
            _RT = new RT[3];

            _RT[0] = new RT(40000.0, 0.0, 1.0);
            _RT[1] = new RT(10000.0, 25.0, 1.0);
            _RT[2] = new RT(1000.0, 85.0, 1.0);
            L = new double[3];
            Y = new double[3];
            Gamma = new double[2];

            CalculateCoefficients();
        }
        public NTC(RT MinimumRT, RT R25, RT MaximumRT)
        {
            _RT = new RT[3];
            _RT[0] = MinimumRT;
            _RT[1] = R25;
            _RT[2] = MaximumRT;
            L = new double[3];
            Y = new double[3];
            Gamma = new double[2];

            CalculateCoefficients();
        }
        public NTC(NTC newNTC)
        {
            _RT = new RT[3];
            _RT[0] = newNTC.MinimumRT;
            _RT[1] = newNTC.R25;
            _RT[2] = newNTC.MaximumRT;
            L = new double[3];
            Y = new double[3];
            Gamma = new double[2];

            CalculateCoefficients();
        }
        public static NTC operator +(NTC left, Resistor right)
        {
            RT[] newRT = new RT[3];
            RT[] leftRT = new RT[3];
            leftRT[0] = left.MinimumRT;
            leftRT[1] = left.R25;
            leftRT[2] = left.MaximumRT;
            for(int i = 0;i < 3; i++)
            {
                newRT[i] = leftRT[i] + right;
            }
            return new NTC(newRT[0], newRT[1], newRT[2]);
        }
        public static NTC operator ^(NTC left, Resistor right)
        {
            RT[] newRT = new RT[3];
            RT[] leftRT = new RT[3];
            leftRT[0] = left.MinimumRT;
            leftRT[1] = left.R25;
            leftRT[2] = left.MaximumRT;
            for (int i = 0; i < 3; i++)
            {
                newRT[i] = leftRT[i] ^ right;
            }
            return new NTC(newRT[0], newRT[1], newRT[2]);
        }

        public Temperature ConvertToTemperature(double ohm)
        {
            double lnR;
            double kelvin;
            Temperature temperature;
            lnR = Math.Log(ohm);
            kelvin = 1.0 / (A + (B * lnR) + (C * Math.Pow(lnR, 3)));
            temperature = new Temperature(kelvin);
            return temperature;
        }
        public double ConvertToResistance(Temperature temperature)
        {
            double x0 = Math.Log(_RT[2].Resistance);
            for (int i = 0; i < 100; i++)
            {
                double fx = A + B * x0 + C * Math.Pow(x0, 3) - 1.0 / temperature.Kelvin;
                double fxDerivative = B + 3 * C * Math.Pow(x0, 2);
                double x1 = x0 - fx / fxDerivative;

                if (Math.Abs(x1 - x0) < 1e-9)
                    break;

                x0 = x1;
            }

            return Math.Exp(x0);
        }
        private void CalculateCoefficients()
        {
            for (int i = 0; i < 3; i++)
            {
                L[i] = Math.Log(_RT[i].Resistance);
                Y[i] = 1.0 / _RT[i].Temperature.Kelvin;
            }

            Gamma[0] = (Y[1] - Y[0]) / (L[1] - L[0]);
            Gamma[1] = (Y[2] - Y[0]) / (L[2] - L[0]);

            _C = ((Gamma[1] - Gamma[0]) / (L[2] - L[1])) * Math.Pow((L[0] + L[1] + L[2]), -1.0);
            _B = Gamma[0] - (_C * (Math.Pow(L[0], 2) + L[0] * L[1] + Math.Pow(L[1], 2)));
            _A = Y[0] - (L[0] * (_B + _C * Math.Pow(L[0], 2)));
        }
    }
}
