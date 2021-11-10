using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScienceTestTasks
{
    class ClassForSolvingSLE
    {
        // simple "wrapper" for visual demonstration of ThreeLinearEquations() function
        public static void Main()
        {
            Console.WriteLine("Task 2 :: three linear equations (hardcoded)");

            int[] result = ThreeLinearEquations();
            
            Console.Write("result: ");
            for (int i = 0; i < result.Length; i++)
                Console.Write("{0} ", result[i]);

            Console.ReadKey();
        }

        // the developed function for Task 2
        public static int[] ThreeLinearEquations()
        {
            int[,] array1 = { { 1, 2, 3},
                            { 0, 1, 2},
                            { 2, 0, 0} };

            int[] array2 = { 1, 1, 0 };

            return new int[] { array1[0, 0] * array2[0] + array1[0, 1] * array2[1] + array1[0, 2] * array2[2],
                                array1[1, 0] * array2[0] + array1[1, 1] * array2[1] + array1[1, 2] * array2[2],
                                array1[2, 0] * array2[0] + array1[2, 1] * array2[1] + array1[2, 2] * array2[2]};
        }
    }
}