using System;

namespace OOP_Lab_2._3._1
{
   public class Program
    {
        static void Main(string[] args)
        {
            static public int First(float[] a, int m)
            {
                int n = 0;
                for (int i = 0; i < m; i++)
                {
                    if (a[i] < 0)
                    {
                        n++;
                    }
                }
                return n;
            }
            static public float Second(float[] a, int m, int index)
            {
                float sum = 0;
                for (int i = index; i < m; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Кількість елементів масиву: ");
                int m = int.Parse(Console.ReadLine());


                int index = 0;
                float sum = 0;
                float[] a = new float[m];
                for (int i = 0; i < m; i++)
                {
                    Console.Write("a[{0}] = ", i);
                    a[i] = float.Parse(Console.ReadLine());

                }
                float min = a[0];
                for (int i = 0; i < m; i++)
                {

                    if (a[i] < min)
                    {
                        min = a[i];
                        index = i;
                    }
                }

                Console.WriteLine("Кількість відємних чисел: {0}", First(a, m));
                Console.WriteLine("Найменший елемент: {0}", min);
                Console.WriteLine("сумф елементів масиву, розташованих після мінімального елемента: {0}", Second(a, m, index));
            }
        }
    }
}
