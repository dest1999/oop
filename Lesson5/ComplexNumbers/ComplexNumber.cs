using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class ComplexNumber
    {
        private double real;
        private double imaginary;
        public ComplexNumber(double Real = 0, string Imaginary = "0i")
        {
            real = Real;

            if (double.TryParse( Imaginary.Trim('i'), out double imaginaryDouble))
            {
                imaginary = imaginaryDouble;
            }
            else
            {
                throw new Exception("Cant parse imaginary value");
            }
        }

        public ComplexNumber(double Real = 0, double Imaginary = 0)
        {
            real = Real;
            imaginary = Imaginary;
        }

        public ComplexNumber()
        {
        }

        public static bool operator == (ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return complexNumber1.real == complexNumber2.real && complexNumber1.imaginary == complexNumber2.imaginary;
        }

        public static bool operator != (ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return !(complexNumber1 == complexNumber2);
        }

        public static ComplexNumber operator + (ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber
                (complexNumber1.real + complexNumber2.real, 
                complexNumber1.imaginary + complexNumber2.imaginary);
        }

        public static ComplexNumber operator - (ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber
                (complexNumber1.real - complexNumber2.real,
                complexNumber1.imaginary - complexNumber2.imaginary);
        }

        public static ComplexNumber operator * (ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber
                (complexNumber1.real * complexNumber2.real - complexNumber1.imaginary * complexNumber2.imaginary,
                complexNumber1.imaginary * complexNumber2.real + complexNumber1.real * complexNumber2.imaginary);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (real == 0 && imaginary == 0)
            {
                return 0.ToString();
            }
            if (real != 0)
            {
                sb.Append(real);
            }
            if (imaginary < 0) 
            { 
                sb.Append($"{imaginary}i");
            }
            if (imaginary > 0)
            {
                sb.Append($"+{imaginary}i");
            }

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not ComplexNumber)
            {
                return false;
            }
            return this == (ComplexNumber)obj;
        }

        public override int GetHashCode()
        {
            return (int)(((this.real + this.imaginary) * (this.real + this.imaginary)) / (real - imaginary));
        }
    }
}
