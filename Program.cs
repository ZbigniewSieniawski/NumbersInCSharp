using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithIntegers();

            void WorkWithIntegers()
            {
                int a = 18;
                int b = 6;
                int c = a + b;
                Console.WriteLine(c);


                // subtraction
                c = a - b;
                Console.WriteLine(c);

                // multiplication
                c = a * b;
                Console.WriteLine(c);

                // division
                c = a / b;
                Console.WriteLine(c);
            }
            OrderPrecedence();

            void OrderPrecedence()
            {

                //Quotient and reminder
                int a = 7;
                int b = 4;
                int c = 3;
                int d = (a + b) / c;
                int e = (a + b) % c;
                Console.WriteLine($"quotient: {d}");
                Console.WriteLine($"remainder: {e}");
            }
            TestLimits();
            
            void TestLimits()
            {
                //C# integer type minimum and maximum limits
                int maxI = int.MaxValue;
                int minI = int.MinValue;
                Console.WriteLine($"The range of integers is {minI} to {maxI}");

                //Underflow or overflow condition. The answer appears to wrap from one limit to the othe other.
                //the answer is very close to the minimum (negative) integer. It's the same as min + 2
                int what = maxI + 3;
                Console.WriteLine($"An example of overflow: {what}");
            }
                WorkWithDoubles();

                void WorkWithDoubles()
                {
                    double e = 19;
                    double f = 23;
                    double g = 8;
                    double h = (e + f) / g;
                    Console.WriteLine(h);

                    //C# double type minimum and maximum limits
                    double maxD = double.MaxValue;
                    double minD = double.MinValue;
                    Console.WriteLine($"The range of double is {minD} to {maxD}");

                    //Rounding errors
                    double third = 1.0 / 3.0;
                    Console.WriteLine(third);
                }
            WorkWithDecimal();

            void WorkWithDecimal()
            {
                decimal min = decimal.MinValue;
                decimal max = decimal.MaxValue;
                Console.WriteLine($"The range of the decimal type is {min} to {max}");
                
                double a = 1.0;
                double b = 3.0;
                Console.WriteLine(a / b);

                decimal c = 1.0M;
                decimal d = 3.0M;
                Console.WriteLine(c / d);

                double radius = 2.50;
                double area = Math.PI * radius * radius;
                Console.WriteLine(area);
            }
        }
    }
}
