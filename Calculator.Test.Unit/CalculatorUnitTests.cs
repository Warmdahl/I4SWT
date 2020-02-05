using System;
using System.Dynamic;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        //Testing add with two parametes
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        //Testing accumulator using add with two parameters
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Accumulator_AccumulateADDNumbers_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing subtract with two parametes
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        //Testing accumulator using sub with two parameters
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Accumulator_AccumulateSUBNumbers_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Subtract(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing multiply with two parametes
        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        //Testing accumulator using multiply with two parameters
        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Accumulator_AccumulateMULTINumbers_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Multiply(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing power with two parametes
        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        //Testing accumulator using Power with two parameters
        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Accumulator_AccumulatePOWERNumbers_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Power(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing divide with two parametes
        [TestCase(10, 2, 5)]
        [TestCase(50, 2, 25)]
        [TestCase(3,0,0.0)]
        public void Divide_DivideNuNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a,b),Is.EqualTo(result));
        }

        //Testing accumulator using divide with two parameters
        [TestCase(10, 2, 5)]
        [TestCase(50, 2, 25)]
        [TestCase(3, 0, 0.0)]
        public void Accumulator_AccumulateDIVIDENumbers_ResultIsCorrect(double a, double b, double result)
        {
            _uut.Divide(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing the clear function
        [TestCase(10,0.0)]
        public void Clear_ClearNuNumbers_ResultIsCorrect(double accu_value, double result)
        {
            _uut.Add(accu_value, 0);
            Assert.That(_uut.Clear,Is.EqualTo(result));
        }

        //Testing add with single parameter
        [TestCase(2,3,2,7)]
        public void Add_AddsingleNumber_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Add(c), Is.EqualTo(result));
        }

        //Testing accumulator using ADD with single parameter.
        [TestCase(2, 3, 2, 7)]
        public void Accumulator_AccumulatorSingleADD_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Add(a, b);
            _uut.Add(c);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
    }
}
