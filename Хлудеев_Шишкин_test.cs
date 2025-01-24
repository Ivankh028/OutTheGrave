using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddsad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число (a):");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число (b):");
            int b = Convert.ToInt32(Console.ReadLine());

            string result = Proverka(a, b);
            Console.WriteLine(result);


        }
        static string Proverka(int a, int b)
        {
            if (b % a == 0 || a % b == 0)
            {
                return "Да, одно из чисел является делителем другого";
            }
            else
            {
                return "Нет, ни одно из чисел не является делителем другого";
            }
        }
    }
}
