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

        //Testing subtract with two parametes
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
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

        //Testing divide with two parametes
        [TestCase(10, 2, 5)]
        [TestCase(50, 2, 25)]
        [TestCase(3,0,0.0)]
        public void Divide_DivideNuNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a,b),Is.EqualTo(result));
        }

        //Testing accumulator
        [TestCase(10,10)]
        public void Accumulator_AccumulateNuNumbers_ResultIsCorrect(double set, double get)
        {
            _uut.Add(set, 0);
            Assert.That(_uut.Accumulator,Is.EqualTo(get));
        }

        //Testing the clear function
        [TestCase(10,0.0)]
        public void Clear_ClearNuNumbers_ResultIsCorrect(double accu_value, double result)
        {
            _uut.Add(accu_value, 0);
            Assert.That(_uut.Clear,Is.EqualTo(result));
        }

        [TestCase(10, 10)]
        public void Accumulator_AccumulateNuNumbers_ResultIsCorrect(double set, double get)
        {
            _uut.Add(set, 0);
            Assert.That(_uut.Accumulator, Is.EqualTo(get));
        }

    }
}
