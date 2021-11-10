using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScienceTestTasks
{
    class ClassForFibonacci
    {
        // simple "wrapper" for visual demonstration of Fibonacci() function
        public static void Main()
        {
            Console.Write("Task 1 :: Fibonacci\n" + "Input number of Fibonacci value: ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("result: {0}" , Fibonacci(0, 1, 1, number));

            Console.ReadKey();
        }

        // the developed function for Task 1
        private static double Fibonacci(double first, double second, int iterator, int numberOfValue)
        {
            if (iterator <= numberOfValue)
                return Fibonacci(second, first + second, iterator + 1, numberOfValue);
            else
                return first;
        }
    }
}