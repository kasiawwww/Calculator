using System;
using NUnit.Framework;
using Moq;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculationsTests
    {
        private Calculations calculations;
        [SetUp]
        public void Init()
        {         
            calculations   = new Calculations();
        }
        [Test]
        [TestCase(2,2, 4)]
        [TestCase(2,3, 5)]
        [TestCase(2,4, 6)]
        [TestCase(2,2.5, 4.5)]

        public void Add_AddsTwoDouble_ReturnsDouble(double a, double b, double c)
        { 
            Assert.AreEqual(c, calculations.Add(a, b));    
        }

        [Test]
        [TestCase(2, 2, 0)]
        [TestCase(2, 3, -1)]
        [TestCase(2, 4, -2)]
        [TestCase(2, 2.5, -0.5)]

        public void Substract_SubstractsTwoDouble_ReturnsDouble(double a, double b, double c)
        {
            Assert.AreEqual(c, calculations.Substract(a, b));
        }

        [Test]
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 6)]
        [TestCase(2, -4, -8)]
        [TestCase(2, 2.5, 5)]

        public void Multiply_MultipliesTwoDouble_ReturnsDouble(double a, double b, double c)
        {
            Assert.AreEqual(c, calculations.Multiply(a, b));
        }

        [Test]
        [TestCase(2, 2, 1)]
        [TestCase(2, 0.5, 4)]
        [TestCase(2, -0.5, -4)]
        [TestCase(5, 2.5, 2)]
        public void Divide_DividesTwoDoubleSecondParameterNotZero_ReturnsDouble(double a, double b, double c)
        {     
            Assert.AreEqual(c, calculations.Divide(a, b));
        }

        [Test]

        [TestCase(5, 0, 2)]
        public void Divide_DividesTwoDoubleSecondParameterZero_ReturnsDouble(double a, int b, double c)
        {
            //Assert.Throws(typeof(DivideByZeroException), (c, calculations.Divide(a, b));
            Assert.Throws(typeof(DivideByZeroException), ()=>calculations.Divide(a,b));

        }
    }
}
