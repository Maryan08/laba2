using System;

namespace OOP_Lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Кількість елементів масиву: ");
            int m = int.Parse(Console.ReadLine());
            int n = 0;
            float min = 0;
            int index = 0;
            float sum = 0;
            float[] a= new float[m];
            for(int i = 0; i < m; i++)
            {
                a[i] = rnd.Next(-100, 100);
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            for(int i = 0; i < m; i++)
            {
                if (a[i] < 0)
                {
                    n++;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    index = i;
                }
            }
            for (int i = index; i < m; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Кількість відємних чисел: {0}", n);
            Console.WriteLine("Найменший елемент: {0}", min);
            Console.WriteLine("сумф елементів масиву, розташованих після мінімального елемента: {0}", sum);
        }
    }
}
