using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите два целых числа:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine("Результат деления: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введены некорректные данные!");
            }
        }
    }
}
