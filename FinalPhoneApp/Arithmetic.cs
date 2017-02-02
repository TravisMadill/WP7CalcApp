using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace FinalPhoneApp
{
    /// <summary>
    /// The name Math was taken.
    /// Anyway, this is where all the calculations happen.
    /// Everything is static to allow easy access.
    /// </summary>
    public static class Arithmetic
    {
        /// <summary>
        /// The memory of the caluclator right now.
        /// </summary>
        static double mem = 0.0;

        /// <summary>
        /// Raises a number to a power.
        /// </summary>
        /// <param name="num">The number to raise.</param>
        /// <param name="power">The power to raise by.</param>
        /// <returns>The number raised to the specified power.</returns>
        public static double nthPower(double num, double power)
        {
            return Math.Pow(num, power);
        }

        /// <summary>
        /// "Roots" a number, so to speak.
        /// </summary>
        /// <param name="num">The number to root.</param>
        /// <param name="root">The root number.</param>
        /// <returns>The number "rooted" to the specified root.</returns>
        public static double nthRoot(double num, double root)
        {
            return Math.Pow(num, 1 / root);
        }

        /// <summary>
        /// Gives the log of a number to a specific base.
        /// </summary>
        /// <param name="num">The number to take the log of.</param>
        /// <param name="logBase">The base of the log.</param>
        /// <returns>The exponent that results in the number given rasied to the base given.</returns>
        public static double nthLogBase(double num, double logBase)
        {
            return Math.Log(num, logBase);
        }

        /// <summary>
        /// Performs a factorial on the number given.
        /// </summary>
        /// <param name="num">The number to "factorialize".</param>
        /// <returns></returns>
        public static double factorial(int num)
        {
            double result = 1;
            while (num >= 1)
            {
                result *= num;
                num--;
            }
            return result;
        }

        /// <summary>
        /// Converts a specified angle from radians to degrees.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The angle in degrees.</returns>
        public static double toDegrees(double angle)
        {
            return angle * 180 / Math.PI;
        }

        /// <summary>
        /// Converts a specified angle from degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns>The angle in radians.</returns>
        public static double toRadians(double angle)
        {
            return angle * Math.PI / 180;
        }

        /// <summary>
        /// Takes the sine of an angle in degrees.
        /// </summary>
        /// <param name="ratio">The number to take the sine of. (Degrees)</param>
        /// <returns>The sine of the specified number.</returns>
        public static double degSine(double ratio)
        {
            return Math.Sin(toRadians(ratio));
        }

        /// <summary>
        /// Takes the sine of an angle in radians.
        /// </summary>
        /// <param name="ratio">The number to take the sine of. (Radians)</param>
        /// <returns>The sine of the specified number.</returns>
        public static double radSine(double ratio)
        {
            return Math.Sin(ratio);
        }

        /// <summary>
        /// Takes the cosine of an angle in degrees.
        /// </summary>
        /// <param name="ratio">The number to take the cosine of. (Degrees)</param>
        /// <returns>The cosine of the specified number.</returns>
        public static double degCosine(double ratio)
        {
            return Math.Cos(toRadians(ratio));
        }

        /// <summary>
        /// Takes the cosine of an angle in radians.
        /// </summary>
        /// <param name="ratio">The number to take the sine of. (Radians)</param>
        /// <returns>The cosine of the specified number.</returns>
        public static double radCosine(double ratio)
        {
            return Math.Cos(ratio);
        }

        /// <summary>
        /// Takes the tangent of an angle in degrees.
        /// </summary>
        /// <param name="ratio">The number to take the tangent of. (Degrees)</param>
        /// <returns>The tangent of the specified number.</returns>
        public static double degTangent(double ratio)
        {
            return Math.Tan(toRadians(ratio));
        }

        /// <summary>
        /// Takes the tangent of an angle in radians.
        /// </summary>
        /// <param name="ratio">The number to take the sine of. (Radians)</param>
        /// <returns>The tangent of the specified number.</returns>
        public static double radTangent(double ratio)
        {
            return Math.Tan(ratio);
        }

        /// <summary>
        /// Takes the inverse sine of a number.
        /// </summary>
        /// <param name="ratio">The sine ratio to find.</param>
        /// <returns>The angle of the ratio. (Degrees)</returns>
        public static double degInvSine(double ratio)
        {
            return toDegrees(Math.Asin(ratio));
        }

        /// <summary>
        /// Takes the inverse sine of a number.
        /// </summary>
        /// <param name="ratio">The sine ratio to find.</param>
        /// <returns>The angle of the ratio. (Radians)</returns>
        public static double radInvSine(double ratio)
        {
            return Math.Asin(ratio);
        }

        /// <summary>
        /// Takes the inverse cosine of a number.
        /// </summary>
        /// <param name="ratio">The cosine ratio to find.</param>
        /// <returns>The angle of the ratio. (Degrees)</returns>
        public static double degInvCosine(double ratio)
        {
            return toDegrees(Math.Acos(ratio));
        }

        /// <summary>
        /// Takes the inverse cosine of a number.
        /// </summary>
        /// <param name="ratio">The cosine ratio to find.</param>
        /// <returns>The angle of the ratio. (Radians)</returns>
        public static double radInvCosine(double ratio)
        {
            return Math.Acos(ratio);
        }

        /// <summary>
        /// Takes the inverse tangent of a number.
        /// </summary>
        /// <param name="ratio">The tangent ratio to find.</param>
        /// <returns>The angle of the ratio. (Degrees)</returns>
        public static double degInvTangent(double ratio)
        {
            return toDegrees(Math.Atan(ratio));
        }

        /// <summary>
        /// Takes the inverse tangent of a number.
        /// </summary>
        /// <param name="ratio">The sine ratio to find.</param>
        /// <returns>The angle of the ratio. (Radians)</returns>
        public static double radInvTangent(double ratio)
        {
            return Math.Atan(ratio);
        }

        /// <summary>
        /// Gets or sets the calculator memory.
        /// </summary>
        public static double Memory
        {
            get { return mem; }
            set { mem = value; }
        }
    }
}
