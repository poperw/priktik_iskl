using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите размер массива:");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                int sum = 0;
                Console.WriteLine("Введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    sum += arr[i];
                }
                Console.WriteLine("Сумма элементов: " + sum);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
        }
    }
}
