using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Введите индекс элемента от 0 до 4:");
            try
            {
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Элемент массива: " + mas[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: выход за границы массива!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный ввод индекса!");
            }
        }
    }
}
