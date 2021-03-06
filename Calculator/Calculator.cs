﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double Power(double a, double b)
        {
            return Accumulator = Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0.0)
            {
                Console.WriteLine("You cannot divide by zero, type an actual number");
                return Accumulator = 0.0;
            }
            else
            {
                return Accumulator = dividend / divisor;
            }
        }

        public double Clear()
        {
            return Accumulator = 0.0;
        }

        public double Accumulator
        {
            get; 
            
            private set;
        }


        //Metode overloads - only receiving one parameter to each method and utilizing accumulator as second parameter.
        public double Add(double a)
        {
            return Accumulator += a;
        }

        public double Subtract(double a)
        {
            return Accumulator -= a;
        }

        public double Multiply(double a)
        {
            return Accumulator = Accumulator * a;
        }

        public double Power(double a)
        {
            return Accumulator = Math.Pow(Accumulator, a);
        }

        public double Divide(double divisor)
        {
            if (divisor == 0.0)
            {
                Console.WriteLine("You cannot divide by zero, type an actual number");
                return Accumulator = 0.0;
            }
            else
            {
                return Accumulator = Accumulator / divisor;
            }
        }
    }
}
