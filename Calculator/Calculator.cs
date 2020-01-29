using System;

namespace Calculator
{
    public class Calculator
    {
        private double cur_num;
        public double Add(double a, double b)
        {
            return cur_num = a + b;
        }

        public double Subtract(double a, double b)
        {
            return cur_num = a - b;
        }

        public double Multiply(double a, double b)
        {
            return cur_num = a * b;
        }

        public double Power(double a, double b)
        {
            return cur_num = Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0.0)
            {
                Console.WriteLine("You cannot divide by zero, type an actual number");
                return cur_num = 0.0;
            }
            else
            {
                return cur_num = dividend / divisor;
            }
        }

        public double Clear()
        {
            return 0.0;
        }

        public double Accumulator(double value)
        {
            //double acu_result = cur_num;
            //get {return cur_num;}

            //private set { cur_num = value; }

            return 0.0;
        }
    }
}
