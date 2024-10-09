using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTC_Emulator.EmulationComponent
{
    public class Temperature
    {
        public enum Units
        {
            Celsius,
            Fahrenheit,
            Kelvin
        }
        private double _Celsius;
        private double _Fahrenheit;
        private double _Kelvin;

        public double Celsius
        {
            get { return _Celsius; }
            set
            {
                _Celsius = value;
                _Fahrenheit = CelsiusToFahrenheit(value);
                _Kelvin = CelsiusToKelvin(value);
            }
        }
        public double Fahrenheit
        {
            get { return _Fahrenheit; }
            set
            {
                _Fahrenheit = value;
                _Celsius = FahrenheitToCelsius(value);
                _Kelvin = FahrenheitToKelvin(value);
            }
        }
        public double Kelvin
        {
            get { return _Kelvin; }
            set
            {
                _Kelvin = value;
                _Celsius = KelvinToCelsius(value);
                _Fahrenheit = KelvinToFahrenheit(value);
            }
        }
        public Temperature()
        {
            Celsius = 25.0;
        }
        public Temperature(double kelvin)
        {
            Kelvin = kelvin;
        }
        public static bool operator >(Temperature a, Temperature b)
        {
            if (a.Kelvin > b.Kelvin)
                return true;
            else
                return false;
        }
        public static bool operator >=(Temperature a, Temperature b)
        {
            if (a.Kelvin >= b.Kelvin)
                return true;
            else
                return false;
        }
        public static bool operator <(Temperature a, Temperature b)
        {
            if (a.Kelvin < b.Kelvin)
                return true;
            else
                return false;
        }
        public static bool operator <=(Temperature a, Temperature b)
        {
            if (a.Kelvin <= b.Kelvin)
                return true;
            else
                return false;
        }
        public void SetTemperature(double temperature, Units unit)
        {
            switch(unit)
            {
                case Units.Fahrenheit:
                    Fahrenheit = temperature;
                    break;
                case Units.Kelvin:
                    Kelvin = temperature;
                    break;
                default:
                    Celsius = temperature;
                    break;
            }
        }
        public double GetTemperature(Units unit)
        {
            double ret = _Celsius;
            switch(unit)
            {
                case Units.Fahrenheit:
                    ret = _Fahrenheit;
                    break;
                case Units.Kelvin:
                    ret = _Kelvin;
                    break;
                default:
                    break;
            }
            return ret;
        }
        static public string GetDescription(Units unit)
        {
            string ret;
            switch(unit)
            {
                case Units.Fahrenheit:
                    ret = "℉";
                    break;
                case Units.Kelvin:
                    ret = "K";
                    break;
                default:
                    ret = "℃";
                    break;
            }
            return ret;
        }
        static public double CelsiusToKelvin(double Celsius)
        {
            return Celsius + 273.15;
        }
        static public double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 9.0 / 5.0) + 32.0;
        }
        static public double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32.0) * 5.0 / 9.0;
        }
        static public double FahrenheitToKelvin(double Fahrenheit)
        {
            return CelsiusToKelvin(FahrenheitToCelsius(Fahrenheit));
        }
        static public double KelvinToCelsius(double Kelvin)
        {
            return Kelvin - 273.15;
        }
        static public double KelvinToFahrenheit(double Kelvin)
        {
            return CelsiusToFahrenheit(KelvinToCelsius(Kelvin));
        }
    }
}
