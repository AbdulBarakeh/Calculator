using System;

//testing git
namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            return (Accumulator = a + b);
        }

        public double Add(double a)
        {
            return Accumulator += a;
        }

        public double Subtract(double a, double b)
        {
            return (Accumulator = (a - b));
        }

        public double Subtract(double a)
        {
            return Accumulator -= a;
        }

        public double Multiply(double a, double b)
        {
            return (Accumulator = (a * b));
        }

        public double Multiply(double a)
        {
            return Accumulator *= a;
        }

        public double Power(double a, double b)
        {
            return (Accumulator = Math.Pow(a, b));
        }

        public double Power(double a)
        {
            return Accumulator = Math.Pow(Accumulator, a);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            return (Accumulator = (dividend / divisor));
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            return Accumulator /= divisor;
        }

        public double Modulus(int a, int b)
        {
            return (double) (Accumulator = (a % b));
        }

        public double Modulus(int a)
        {
            return (double) (Accumulator %= a);
        }

        public double SquareRoot(double a)
        {
            return (Accumulator = Math.Sqrt(a));
        }

        public double SquareRoot()
        {
            return Math.Sqrt(Accumulator);

        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
