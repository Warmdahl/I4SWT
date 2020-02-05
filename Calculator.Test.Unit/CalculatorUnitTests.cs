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
        [TestCase(10,10,5,25)]
        [TestCase(13,7,2,22)]
        [TestCase(2,1,128,131)]
        public void Add_AddSingleNumber_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Add(c), Is.EqualTo(result));
        }

        //Testing accumulator using ADD with single parameter.
        [TestCase(2, 3, 2, 7)]
        [TestCase(10, 10, 5, 25)]
        [TestCase(13, 7, 2, 22)]
        [TestCase(2, 1, 128, 131)]
        public void Accumulator_AccumulatorSingleADD_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Add(a, b);
            _uut.Add(c);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing Sub with single parameter
        [TestCase(10, 5, 2, 3)]
        [TestCase(15,15,5,-5)]
        [TestCase(20,15,5,0)]
        [TestCase(17,8,4,5)]
        public void Subtract_SubtractSingleNumbers_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Subtract(a, b);
            Assert.That(_uut.Subtract(c), Is.EqualTo(result));
        }

        //Testing accumulator using Sub with single parameter.
        [TestCase(10, 5, 2, 3)]
        [TestCase(15, 15, 5, -5)]
        [TestCase(20, 15, 5, 0)]
        [TestCase(17, 8, 4, 5)]
        public void Accumulator_AccumulatorSingleSub_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Subtract(a, b);
            _uut.Subtract(c);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing multiply with single parameter.
        [TestCase(10,2,2,40)]
        public void Multiply_MultiplySingleNunmbers_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Multiply(a, b);
            Assert.That(_uut.Multiply(c), Is.EqualTo(result));
        }

        //Testing accumulator using multiply with single parameter.
        [TestCase(10, 2, 2, 40)]
        public void Accumulator_AccumulatorSingleMulit_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Multiply(a, b);
            _uut.Multiply(c);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Testing power with single parameter.

        public void Power_RaiseSingleNumbers_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Power(a, b);
            Assert.That(_uut.Power(c), Is.EqualTo(result));
        }

        //Testing accumulator using power with single parameter.

        public void Accumulator_AccumulatorSinglePower_ResultIsCorrect(double a, double b, double c, double result)
        {
            _uut.Power(a, b);
            _uut.Power(c);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
    }
}
