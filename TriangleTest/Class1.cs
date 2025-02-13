using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class EquilateralTest1
    {
        [Test]

        public void EquilateralTriangle_AllSidesEqual_OutputValidTriangle()
        {
            //Arrange
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Equilateral triangle";

            //Act
            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, Actual);
        }
    }
/*
    [TestFixture]
    public class IsoscelesTest1
    {
        [Test]

        public void IsoscelesTriangle_AnyTwoSidesEqual_OutputIsoscelesTriangle()
        {
            int firstSide = 50;
            int secondSide = 50;
            int thirdSide = 80;

            string expected = "Isosceles triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class IsoscelesTest2
    {
        [Test]

        public void IsoscelesTriangle_TwoSidesEqual_OutputIsoscelesTriangle()
        {
            int firstSide = 80;
            int secondSide = 50;
            int thirdSide = 50;

            string expected = "Isosceles triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }


    [TestFixture]
    public class IsoscelesTest3
    {
        [Test]

        public void IsoscelesTriangle_TwoSidesEqual_OutputIsoscelesTriangle()
        {
            int firstSide = 50;
            int secondSide = 80;
            int thirdSide = 50;

            string expected = "Isosceles triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ScaleneTest1
    {
        [Test]

        public void ScaleneTriangle_NoSidesEqual_OutputScaleneTriangle()
        {
            int firstSide = 60;
            int secondSide = 50;
            int thirdSide = 70;

            string expected = "Scalene triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ScaleneTest2
    {
        [Test]

        public void ScaleneTriangle_NoSidesEqual_OutputScaleneTriangle()
        {
            int firstSide = 50;
            int secondSide = 60;
            int thirdSide = 70;

            string expected = "Scalene triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ScaleneTest3
    {
        [Test]

        public void ScaleneTriangle_NoSidesEqual_OutputScaleneTriangle()
        {
            int firstSide = 70;
            int secondSide = 60;
            int thirdSide = 50;

            string expected = "Scalene triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ScaleneTest4
    {
        [Test]

        public void ScaleneTriangle_NoSidesEqual_OutputScaleneTriangle()
        {
            int firstSide = 45;
            int secondSide = 60;
            int thirdSide = 75;

            string expected = "Scalene triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ScaleneTest5
    {
        [Test]

        public void ScaleneTriangle_NoSidesEqual_OutputScaleneTriangle()
        {
            int firstSide = 60;
            int secondSide = 45;
            int thirdSide = 75;

            string expected = "Scalene triangle";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ZeroTest1
    {
        [Test]

        public void InvalidTriangle_ZeroSide_OutputInvalidTriangle()
        {
            int firstSide = 0;
            int secondSide = 45;
            int thirdSide = 75;

            string expected = "Invalid Triangle - a zero has been detected";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ZeroTest2
    {
        [Test]

        public void InvalidTriangle_ZeroSide_OutputInvalidTriangle()
        {
            int firstSide = 60;
            int secondSide = 0;
            int thirdSide = 75;

            string expected = "Invalid Triangle - a zero has been detected";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class ZeroTest3
    {
        [Test]

        public void InvalidTriangle_ZeroSide_OutputInvalidTriangle()
        {
            int firstSide = 60;
            int secondSide = 45;
            int thirdSide = 0;

            string expected = "Invalid Triangle - a zero has been detected";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }

    [TestFixture]
    public class InvalidTest1
    {
        [Test]

        public void InvalidTriangle_InvalidSide_OutputInvalidTriangle()
        {
            int firstSide = 30;
            int secondSide = 45;
            int thirdSide = 105;

            string expected = "INVALID!!";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }


    [TestFixture]
    public class InvalidTest2
    {
        [Test]

        public void InvalidTriangle_InvalidSide_OutputInvalidTriangle()
        {
            int firstSide = 105;
            int secondSide = 45;
            int thirdSide = 30;

            string expected = "INVALID!!";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }


    [TestFixture]
    public class InvalidTest3
    {
        [Test]

        public void InvalidTriangle_InvalidSide_OutputInvalidTriangle()
        {
            int firstSide = 45;
            int secondSide = 105;
            int thirdSide = 30;

            string expected = "INVALID!!";

            string Actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, Actual);
        }
    }



    */



}
