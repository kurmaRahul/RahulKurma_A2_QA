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

    }
}
