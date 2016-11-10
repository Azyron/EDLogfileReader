using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDLogfileReader
{
    public class Position
    {
        public double X;
        public double Y;
        public double Z;

        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");



        public Position(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }


        public String toString()
        {
            return X.ToString(culture) + ", " + Z.ToString(culture) + ", " + Y.ToString(culture);
        }


        public double distanceTo(Position otherPosition)
        {
            double a = X - otherPosition.X;
            double b = Y - otherPosition.Y;
            double c = Z - otherPosition.Z;
            return Math.Sqrt(Math.Pow(Math.Abs(X - otherPosition.X), 2) + Math.Pow(Math.Abs(Y - otherPosition.Y), 2) + Math.Pow(Math.Abs(Z - otherPosition.Z), 2));
        }
    }
}
