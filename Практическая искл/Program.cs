
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_искл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");

            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Вы ввели число: " + a);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка: введено не целое число!");
            }
        }
    }
}
