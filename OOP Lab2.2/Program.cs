using System;

namespace OOP_Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            for(double i = -(Math.PI / 2); i <= Math.PI / 2; i += Math.PI / 20)
            {
                a = 1 / Math.Tan(i);
                if (i == 0)
                {
                    Console.WriteLine("x = {0}       y = не існує", i);
                }
                else
                {
                    Console.WriteLine("x = {0}       y = {1}", i, a);
                }
            }

        }
    }
}
