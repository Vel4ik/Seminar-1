using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        int Max = number1;
       
        if (number2 > Max) Max = number2;
        if (number3 > Max) Max = number3;
        Console.WriteLine("Максимальное число: ");
        Console.WriteLine(Max);
    }
}