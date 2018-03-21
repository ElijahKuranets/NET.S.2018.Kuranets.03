using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNthRoot.NUnitTsets
{
    [TestFixture]
    public class NUnitTests
    {
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]


        public void NewtonMethod(double number, int degree, double precision, double result)
        {
            Assert.AreEqual(FindNthRootLib.FindNthRootClassLib.FindNthRoot(number, degree, precision), result, precision);
        }

        [TestCase(8, 15, -7, -5)]
        [TestCase(8, 15, -0.6, -0.1)]

        public void FindNthRoot_Number_Degree_Precision_ArgumentOutOfRangeException(int number, int degree, double precision, double expected)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FindNthRootLib.FindNthRootClassLib.FindNthRoot(number, degree, precision));
        }


    }
}
