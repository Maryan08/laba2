using System;

namespace OOP_Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть порядковий номер дня тижня");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Це понеділок");break;
                case 2:
                    Console.WriteLine("Це вівторок"); break;
                case 3:
                    Console.WriteLine("Це середа"); break;
                case 4:
                    Console.WriteLine("Це четвер"); break;
                case 5:
                    Console.WriteLine("Це пятниця"); break;
                case 6:
                    Console.WriteLine("Це субота"); break;
                case 7:
                    Console.WriteLine("Це неділя"); break;
                default:
                    Console.WriteLine("В тижні всього 7 днів"); break;
            }

        }
    }
}