using System;

namespace lesson_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
         

            int x = 5;
            Console.WriteLine(-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15);

            Console.WriteLine(Math.Abs(x) * Math.Sin(x));

           
            Console.WriteLine(2 * Math.PI * x);
            Console.WriteLine(Math.Max(a, b));

       
        }
    }
}
