using System;
using System.Linq;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("������� ������ �����: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("������� ������ �����: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("����� ����� ����� " + (a + b));
        }
    }
}
