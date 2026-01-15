using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 целых чисел:");
            int[] arr6 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                bool ok = false;
                while (!ok)
                {
                    try
                    {
                        Console.Write("Элемент [" + i + "] = ");
                        arr6[i] = int.Parse(Console.ReadLine());
                        ok = true;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Повторите ввод элемента.");
                    }
                }
            }
            Console.WriteLine("Массив успешно заполнен.");
        }
    }
}
