namespace NUnit2
{
    using System;
    using NUnit.Framework;

    public class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Test_Addition()
        {
            Assert.AreEqual(5, Calculator.Add(2, 3));
            Assert.AreEqual(-1, Calculator.Add(-2, 1));
        }

        [Test]
        public void Test_Subtraction()
        {
            Assert.AreEqual(1, Calculator.Subtract(3, 2));
            Assert.AreEqual(-3, Calculator.Subtract(-2, 1));
        }

        [Test]
        public void Test_Multiplication()
        {
            Assert.AreEqual(6, Calculator.Multiply(2, 3));
            Assert.AreEqual(-2, Calculator.Multiply(-1, 2));
        }

        [Test]
        public void Test_Division()
        {
            Assert.AreEqual(2, Calculator.Divide(6, 3));
            Assert.AreEqual(-2, Calculator.Divide(-6, 3));
        }

        [Test]
        public void Test_DivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(1, 0));
        }
    }

}
