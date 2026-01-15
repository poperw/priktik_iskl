using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массивов:");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                int[] b = new int[n];
                double[] c = new double[n];
                Console.WriteLine("Введите элементы первого массива:");
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите элементы второго массива:");
                for (int i = 0; i < n; i++)
                    b[i] = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        c[i] = (double)a[i] / b[i];
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"Ошибка: деление на ноль в элементе {i}");
                        c[i] = 0;
                    }
                }
                Console.WriteLine("Результирующий массив:");
                for (int i = 0; i < n; i++)
                    Console.WriteLine(c[i]);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }

        }
    }
}
