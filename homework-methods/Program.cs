using System;

namespace homework_methods
{
     class Program
    {
        static int MaximumValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static double MaximumValue(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void MinimumValue(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine("Minimum is a");
            }
            else
            {
                Console.WriteLine("Minimum is b");
            }
        }



        static void Main(string[] args)
        {
            //MaximumValue(13.9, 5.7);
            MinimumValue(10, 25);
            int myNum1 = MaximumValue(8, 5);
            double myNum2 = MaximumValue(18.2, 5.9);
            Console.WriteLine("Max: " + myNum1);
            Console.WriteLine("Max: " + myNum2);


        }
    }
}

