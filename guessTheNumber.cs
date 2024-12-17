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
            Console.WriteLine("������, � ������� ����� �� 1 �� 100\n�������� ������ ���!");
            int input = 0;
            while (number != input)
            {
                Console.Write($"������� ����� (������� ����� {count}): ");
                input = Convert.ToInt32(Console.ReadLine());
                if (number != input)
                {
                    if (number > input)
                    {
                        Console.WriteLine("�� �� ������, ����� ������");
                    }
                    else
                    {
                        Console.WriteLine("�� �� ������, ����� ������");
                    }
                }
                else
                {
                    Console.WriteLine($"���������� �� ������ ���������� �����, �������� {count} �������");
                }
                count++;
            }
        }
    }
}
