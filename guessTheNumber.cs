using System;
using System.Linq;

namespace guessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int count = 1;
            Console.WriteLine("Привет, я загадал число от 1 до 100\nПопробуй угадай его!");
            int input = 0;
            while (number != input)
            {
                Console.Write($"Введите число (Попытка номер {count}): ");
                input = Convert.ToInt32(Console.ReadLine());
                if (number != input)
                {
                    if (number > input)
                    {
                        Console.WriteLine("Ты не угадал, число больше");
                    }
                    else
                    {
                        Console.WriteLine("Ты не угадал, число меньше");
                    }
                }
                else
                {
                    Console.WriteLine($"Поздравляю ты угадал загаданное число, потратив {count} попыток");
                }
                count++;
            }
        }
    }
}
