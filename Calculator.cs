using System;

namespace calculate_refactor
{
    class Calculator
    {
        public static int Calculate(int a, int b, char o)
        {
            switch (o)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b != 0)
                        return a / b;
                    else
                        throw new Exception("Can not divide by 0");
                default:
                    throw new Exception("Unsupported operation");
            }
        }

    }
}