using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    PrintThousand();
        //}
        {
            ThreesCompany();

        }

        //write a method that will print to the console
        //numbers 3 through 999 by 3 each time.
        public static void ThreesCompany()
        {
            for (int t = 3; t <= 999; t += 3)
            {
                Console.WriteLine(t);
            }
        }


        //write a method that will print to the console
        //all numbers 1000 through -1000
        //public static void PrintThousand()
        //{
        //    for (int i = 1000; i >= -1000; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

    }
}

