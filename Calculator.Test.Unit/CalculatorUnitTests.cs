using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("GRUPPE 12")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_AddParamAndAccumulator_ResultIsCorrect()
        { 
            _uut.Add(2, 2);

            var result = _uut.Add(4);
            
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_SubtractParamAndAccumulator_ResultIsCorrect()
        {
            _uut.Subtract(8, 4);

            var result = _uut.Subtract(2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_MultiplyParamAndAccumulator_ResultIsCorrect()
        {
            _uut.Multiply(2, 2);

            var result = _uut.Multiply(4);

            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void Power_ParamAndAccumulator_ResultIsCorrect()
        {
            _uut.Power(2, 2);

            var result = _uut.Power(4);

            Assert.That(result, Is.EqualTo(256));

        }

        [Test]
        public void Divide_DivideParamAndAccumulator_ResultIsCorrect()
        {
            _uut.Divide(4, 2);

            var result = _uut.Divide(2);

            Assert.That(result, Is.EqualTo(1));
        }

        // A single test case, with fixed input and expected output
        [Test]
        public void Add_Add2And3_ResultIs5()
        {
            // Act
            var result = _uut.Add(4, 3);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        // The TestCase feature allows reusing test code for diffent input and expected output
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            // Combining the Act and Assert steps is also possible
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


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


        [TestCase(4, 2, 2)]
        [TestCase(4, -2, -2)]
        [TestCase(-4, -2, 2)]
        [TestCase(1, 2, 0.5)]
        [TestCase(1.0, 2.0, 0.5)]
        [TestCase(-1.5, 2.0, -0.75)]
        public void Divide_DivideNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }


        //Divide By Zero does not throw exception in C# but results in positive/negative Infinity or NaN 
        // https://docs.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception?view=netframework-4.7.2

        [TestCase(1.5, 0)]
        public void Divide_DivideByZero_ThrowsDivideByZeroException(double a, double b)
        {
            Assert.That(() => _uut.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }

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

        // For floating point results, exact equal comparison can be tricky
        // Use EqualTo modifier Within
        [Test]
        public void Power_SquareRootHalf_ResultIsWithinPrecision()
        {
            // Raising a number to 1/2 is the same as taking the square root
            double result = _uut.Power(0.5, 0.5);

            Assert.That(result, Is.EqualTo(0.707107).Within(0.0000005));
        }

        [Test]

        [TestCase(144, 12)]
        [TestCase(25, 5)]
        [TestCase(36, 6)]
        public void Square_Root_ResultIsCorrect(double a, double result)
        {
            Assert.That(_uut.SquareRoot(a), Is.EqualTo(result));
        }
      

        public void Power_5_ToThePowerOf_5_Result_3125()
        {
            _uut.Add(2, 3);

            var result = _uut.Power(5);

            Assert.That(result, Is.EqualTo(3125));
        }

        [Test]
        public void Testing_Accumulator_Clear()
        {
            _uut.Add(5, 5);

            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        
        }

        [Test]
        public void SingleArgument_Multiplier()
        {
            _uut.Multiply(5, 5);

            var result = _uut.Multiply(2);

            Assert.That(result, Is.EqualTo(50));
        }

        [TestCase(2, 4)]
        [TestCase(5, 25)]
        [TestCase(7, 49)]
        [TestCase(6, 36)]
        [TestCase(10, 100)]
        public void SingleArg_Multiplier_ExtTest(double a, double result)
        {
            _uut.Multiply(1, a);

            Assert.That(_uut.Multiply(a), Is.EqualTo(result));
        }

        [TestCase(5, 2, 1)]
        [TestCase(8, 3, 2)]
        [TestCase(10, 5, 0)]
        [TestCase(15, 2, 1)]
        [TestCase(10, 1, 0)]
        [TestCase(7, 5, 2)]
        [TestCase(9, 3, 0)]
        public void Modulus_ModuluToIntegers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Modulus(a, b), Is.EqualTo(result));
        }

        [TestCase(10, 6, 2, 0)]
        [TestCase(10, 6, 3, 1)]
        [TestCase(15, 8, 4, 3)]
        public void Modulus_ModulusAccOneIntegers_ResultIsCorrect(int a, int b, int c, int result)
        {
            _uut.Modulus(a, b);
            
            Assert.That(_uut.Modulus(c), Is.EqualTo(result));

        }
    }
}
