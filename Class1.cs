using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject1_for_practical_work_2
{
    public class ComplexNumber
    {
        double RealPart = 0;
        double ImaginaryPart = 0;

        public ComplexNumber(double real, double imaginary)
        {
            RealPart = real;
            ImaginaryPart = imaginary;
        }

        public override string ToString()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }

        public static ComplexNumber operator +(ComplexNumber n1, ComplexNumber n2)
        {
            double RealSum = n1.RealPart + n2.RealPart;
            double ImaginarySum = n1.ImaginaryPart + n2.ImaginaryPart;
            return new ComplexNumber(RealSum, ImaginarySum);
        }

        public static ComplexNumber operator +(ComplexNumber n, double real)
        {
            return new ComplexNumber(n.RealPart + real, n.ImaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber n1, ComplexNumber n2)
        {
            double RealSum = n1.RealPart - n2.RealPart;
            double ImaginarySum = n1.ImaginaryPart - n2.ImaginaryPart;
            return new ComplexNumber(RealSum, ImaginarySum);
        }

        public static ComplexNumber operator -(ComplexNumber n, double real)
        {
            return new ComplexNumber(n.RealPart - real, n.ImaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber n1, ComplexNumber n2)
        {
            double RealSum = n1.RealPart * n2.RealPart - n1.ImaginaryPart * n2.ImaginaryPart;
            double ImaginarySum = n1.RealPart * n2.ImaginaryPart + n1.ImaginaryPart * n2.RealPart;
            return new ComplexNumber(RealSum, ImaginarySum);
        }

        public static ComplexNumber operator *(ComplexNumber n, double real)
        {
            return new ComplexNumber(n.RealPart * real, n.ImaginaryPart);
        }

        public static bool operator true(ComplexNumber n)
        {
            return n.RealPart != 0 || n.ImaginaryPart != 0;
        }

        public static bool operator false(ComplexNumber n)
        {
            return n.RealPart == 0 && n.ImaginaryPart == 0;
        }

        public static implicit operator int(ComplexNumber n)
        {
            return (int)n.RealPart;
        }

        public static explicit operator double(ComplexNumber n)
        {
            return n.RealPart;
        }

        public static bool operator ==(ComplexNumber n1, ComplexNumber n2)
        {
            if (ReferenceEquals(n1, null) &&  ReferenceEquals(n2, null)) return true;
            if (ReferenceEquals(n1, null) || ReferenceEquals(n2, null)) return false;
            return n1.RealPart == n2.RealPart && n1.ImaginaryPart == n2.ImaginaryPart;
        }

        public static bool operator !=(ComplexNumber n1, ComplexNumber n2)
        {
            return !(n1 == n2);
        }

        public double Magnitude()
        {
            return Math.Sqrt(RealPart * RealPart + ImaginaryPart * ImaginaryPart);
        }

        public static bool operator >(ComplexNumber n1, ComplexNumber n2)
        {
            return n1.Magnitude() > n2.Magnitude();
        }

        public static bool operator >=(ComplexNumber n1, ComplexNumber n2)
        {
            return n1.Magnitude() >= n2.Magnitude();
        }
        public static bool operator <(ComplexNumber n1, ComplexNumber n2)
        {
            return n1.Magnitude() < n2.Magnitude();
        }
        public static bool operator <=(ComplexNumber n1, ComplexNumber n2)
        {
            return n1.Magnitude() <= n2.Magnitude();
        }
    }
}