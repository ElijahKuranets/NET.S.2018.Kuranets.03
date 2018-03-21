using System;

namespace FindNthRootLib
{
    public class FindNthRootClassLib
    {

        /// <summary>
        ///  Newton's algorithm for getting n-th root of number.
        /// </summary>
        /// <param name="number">A number to get root</param>
        /// <param name="degree">Degree</param>
        /// <param name="accuracy"></param>
        /// <returns>N-th root of 'number'</returns>
        public static double FindNthRoot(double number, int degree, double accuracy)
        {

            if (degree < 0 || degree < int.MinValue || degree > int.MaxValue || accuracy < 0)
            {
                throw new ArgumentOutOfRangeException($"Argument's {nameof(degree)} isn't valid");
            }

            if (degree == 0)
            {
                return 1;
            }
            else if (degree == 1)
            {
                return number;
            }


            var x0 = number / degree;
            var x1 = (1.0 / degree) * ((degree - 1) * x0 + number / Math.Pow(x0, degree - 1));

            while (Math.Abs(x1 - x0) > accuracy)
            {
                x0 = x1;
                x1 = (1.0 / degree) * ((degree - 1) * x0 + number / Math.Pow(x0, degree - 1));

            }

            return x1;
        }
    }
}
