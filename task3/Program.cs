﻿// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Wite N: ");

int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    System.Console.WriteLine("Tablica korney: ");
    for (double i = 1; i <= N; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)} ");
    }
}
else
{
    System.Console.WriteLine("EROR: not an integer");
}