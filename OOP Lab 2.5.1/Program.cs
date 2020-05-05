using System;

namespace OOP_Lab_2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кількість рядків: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Кількість стовпців:");
            int m = int.Parse(Console.ReadLine());
           
            float[,] a = new float[n, m];

            float[] max = new float[n];
            float[] max1 = new float[n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0}][{1}] = ", i, j);
                   a[i,j]=float.Parse( Console.ReadLine());

                }

            for (int k = 0; k < n; k++)
            {

                max[k] = a[k, 0];


            }
            for (int k = 0; k < n; k++)
            {
                for (int i = k; i < k + 1; i++)
                    for (int j = 0; j < m; j++)

                    {
                        if (a[i, j] > max[k])
                        {
                            max[k] = a[i, j];
                        }
                    }
            }

            for (int f = 0; f < n; f++)
            {


                Console.WriteLine("max[{0}] = {1}", f, max[f]);

            }
        }
        }
}
