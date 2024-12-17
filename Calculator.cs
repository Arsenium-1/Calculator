using System;
using System.Linq;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¬ведите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("¬ведите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("—умма чисел равна " + (a + b));
        }
    }
}
