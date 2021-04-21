using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Lesson1_Task1
{
    public class TestCase
    {
        public int X { get; set; }
        public bool Expected { get; set; }
        public Exception ExpectedException { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var tc1 = new TestCase()
            {
                X = 1,
                Expected = true,
                ExpectedException = null
            };

            var tc2 = new TestCase()
            {
                X = 5,
                Expected = true,
                ExpectedException = null
            };

            var tc3 = new TestCase()
            {
                X = 3559,
                Expected = true,
                ExpectedException = null
            };
            // Я не понял, как работать с классом Exception. В вводном курсе нам просто сказали, что такой класс есть. 
            // Я так понял, что отрицательный тест нацелен на подтверждение обработанности всех исключений, у меня в коде обработано одно
            // Не понял (синтаксис), как это исключение протестировать.

            Test_Prime_Number(tc1);
            Test_Prime_Number(tc2);
            Test_Prime_Number(tc3);
        }

        static bool Prime_Number(int number)
        {
            if (number<=0)
            {
                throw new ArgumentException("введите целое положительное число");
            }

            bool result = false;
            int d = 0;
            int i = 2;

            while(i<number)
            {
                if(number%i == 0)
                {
                    d++;
                }

                i++;
            }

            if (d == 0) result = true;
            
            return result;
        }

        static void Test_Prime_Number (TestCase tc)
        {
            try
            {
                var actual = Prime_Number(tc.X);

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
