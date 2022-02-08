using System;

namespace Homework_loop
{
    internal class Homework
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 9;
            int sum = 0;
            do
            {

                Console.WriteLine(sum + a);
                a++;
            }
            while (a < b);
        }
    }
}