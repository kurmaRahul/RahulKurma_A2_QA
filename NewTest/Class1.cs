using System;
using NUnit.Framework;
using TriangleSolver;

namespace NewTest
{
    [TestFixture]
    public class Class1
    {
        //Test for a valid equilateral triangle
        [Test]
        public void AnalyzeTriangle_Input9and9and9_OutputValidEquilateralTriangle()
        {
            // Arrange
            int side1 = 9;
            int side2 = 9;
            int side3 = 9;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", triangleType);
        }



        //Tests for a valid isosceles triangle
        
        [Test]
        public void AnalyzeTriangle_Input5and5and8_OutputValidIsoscelesTriangle1()
        {
            // Arrange
            int sideA = 5;
            int sideB = 5;
            int sideC = 8;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input6and4and4_OutputValidIsoscelesTriangle2()
        {
            // Arrange
            int sideA = 6;
            int sideB = 4;
            int sideC = 4;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input8and10and8_OutputValidIsoscelesTriangle3()
        {
            // Arrange
            int sideA = 8;
            int sideB = 10;
            int sideC = 8;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", triangleType);
        }



        //Tests for a valid scalene triangle

        [Test]
        public void AnalyzeTriangle_Input4and6and5_OutputValidScaleneTriangle()
        {
            // Arrange
            int sideA = 4;
            int sideB = 6;
            int sideC = 5;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input8and9and10_OutputValidScaleneTriangle()
        {
            // Arrange
            int sideA = 8;
            int sideB = 9;
            int sideC = 10;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input9and12and11_OutputValidScaleneTriangle()
        {
            // Arrange
            int sideA = 9;
            int sideB = 12;
            int sideC = 11;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input6and10and5_OutputValidScaleneTriangle()
        {
            // Arrange
            int sideA = 6;
            int sideB = 10;
            int sideC = 5;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input13and11and10_OutputValidScaleneTriangle()
        {
            // Arrange
            int sideA = 13;
            int sideB = 11;
            int sideC = 10;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", triangleType);
        }




        //Tests for verifying a zero length for one or more sides

        [Test]
        public void AnalyzeTriangle_Input0and2and3_OutputZeroLengthSides()
        {
            // Arrange
            int sideA = 0;
            int sideB = 2;
            int sideC = 3;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input6and0and4_OutputZeroLengthSides()
        {
            // Arrange
            int sideA = 6;
            int sideB = 0;
            int sideC = 4;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input0and9and0_OutputZeroLengthSides()
        {
            // Arrange
            int sideA = 0;
            int sideB = 9;
            int sideC = 0;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", triangleType);
        }



        //Tests for verifying an invalid response (other than a zero length)

        [Test]
        public void AnalyzeTriangle_Input2and5and8_OutputInvalidResponse()
        {
            // Arrange
            int sideA = 2;
            int sideB = 5;
            int sideC = 8;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input1and2and5_OutputInvalidResponse()
        {
            // Arrange
            int sideA = 1;
            int sideB = 2;
            int sideC = 5;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", triangleType);
        }

        [Test]
        public void AnalyzeTriangle_Input4and9and15_OutputInvalidResponse()
        {
            // Arrange
            int sideA = 4;
            int sideB = 9;
            int sideC = 15;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", triangleType);
        }

    }
}
