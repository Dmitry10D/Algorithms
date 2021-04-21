using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionComplexity
{
    class Program
    {
        public static int Strange_Sum (int[] InputArray)            // O(1+N*N*N*4+1) => O(N^3), N = InputArray.Length
        {
            int sum = 0;                                            // O(1)
            for (int i = 0; i < InputArray.Length; i++)             // O(N*N*N*4)
            {
                for (int j = 0; j < InputArray.Length; j++)         // O(N*N*4)
                {
                    for (int k = 0; k < InputArray.Length; k++)     // O(N*4)
                    {
                        int y = 0;                                  // O(1)
                        if (j != 0)                                 // O(1)
                        {
                            y = k / j;                              // O(1)
                        }

                        sum += InputArray[i] + i + j + k + y;       // O(1)
                    }
                }
            }
            return sum;                                             // O(1)
        }

        // Ответ: Сложность алгоритма возрастает c увеличением размера массива, как степенная функция N^3
        static void Main(string[] args)
        {
        }
    }
}
