using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 1)
        {
            Console.WriteLine("Число нечётное");
        }
        else
        {
            Console.WriteLine("Число чётное");
        }
    }
}