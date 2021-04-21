using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public class TestCase
        {
            public int X { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static void Main(string[] args)
        {
            var tc1 = new TestCase()
            {
                X = 0,
                Expected = 0,
                ExpectedException = null
            };

            var tc2 = new TestCase()
            {
                X = 1,
                Expected = 1,
                ExpectedException = null
            };

            var tc3 = new TestCase()
            {
                X = 2,
                Expected = 1,
                ExpectedException = null
            };
            var tc4 = new TestCase()
            {
                X = 5,
                Expected = 5,
                ExpectedException = null
            };
            var tc5 = new TestCase()
            {
                X = 10,
                Expected = 55,
                ExpectedException = null
            };
            var tc6 = new TestCase()
            {
                X = -8,
                Expected = -21,
                ExpectedException = null
            };
            var tc7 = new TestCase()
            {
                X = -9,
                Expected = 34,
                ExpectedException = null
            };
            bool Rec = true;
            bool Cyc = false;

            Console.WriteLine("Testing Recursion");
            Test_Fibonacci(tc1, Rec);
            Test_Fibonacci(tc2, Rec);
            Test_Fibonacci(tc3, Rec);
            Test_Fibonacci(tc4, Rec);
            Test_Fibonacci(tc5, Rec);
            Test_Fibonacci(tc6, Rec);
            Test_Fibonacci(tc7, Rec);

            Console.WriteLine("Testing Cycle");
            Test_Fibonacci(tc1, Cyc);
            Test_Fibonacci(tc2, Cyc);
            Test_Fibonacci(tc3, Cyc);
            Test_Fibonacci(tc4, Cyc);
            Test_Fibonacci(tc5, Cyc);
            Test_Fibonacci(tc6, Cyc);
            Test_Fibonacci(tc7, Cyc);
        }

        static int Fibonacci_Rec(int index)
        {
            if (index >= 0)
            {
                if (index == 0) return 0;
                if (index == 1) return 1;
                else return Fibonacci_Rec(index - 1) + Fibonacci_Rec(index - 2);
            }
            else
            {
                if (index == 0) return 0;
                if (index == -1) return 1;
                else return Fibonacci_Rec(index + 2) - Fibonacci_Rec(index + 1);
            }
        }

        static int Fibonacci_Cyc(int index)
        {
            int ind = Math.Abs(index);
            
                if (ind == 0) return 0;
                if (ind == 1) return 1;
                int a = 0;
                int b = 1;
                int res = 0;
                for (var i = 2; i <= ind; i++)
                {
                    res = a + b;
                    a = b;
                    b = res;
                }
                
            if (index < 0)
            {
                int fin = (
                    res * ((int)Math.Pow((-1), (ind + 1)))
                    );
                return fin;
            }
            else
            {
                return res;
            }
        }

        static void Test_Fibonacci(TestCase tc, bool Fib_Rec)
        {
            if (Fib_Rec)
            {
                try
                {

                    var actual = Fibonacci_Rec(tc.X);


                    if (actual == tc.Expected)
                    {
                        Console.WriteLine("VALID TEST");
                    }
                    else
                    {
                        Console.WriteLine("INVALID TEST");
                    }
                }
                catch (Exception ex)
                {
                    if (tc.ExpectedException != null)
                    {
                        Console.WriteLine("VALID TEST");
                    }
                    else
                    {
                        Console.WriteLine("INVALID TEST");
                    }
                }
            }
            else
            {
                try
                {

                    var actual = Fibonacci_Cyc(tc.X);


                    if (actual == tc.Expected)
                    {
                        Console.WriteLine("VALID TEST");
                    }
                    else
                    {
                        Console.WriteLine("INVALID TEST");
                    }
                }
                catch (Exception ex)
                {
                    if (tc.ExpectedException != null)
                    {
                        Console.WriteLine("VALID TEST");
                    }
                    else
                    {
                        Console.WriteLine("INVALID TEST");
                    }
                }
            }
        }
    }
}
