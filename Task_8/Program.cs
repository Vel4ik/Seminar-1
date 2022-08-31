using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}