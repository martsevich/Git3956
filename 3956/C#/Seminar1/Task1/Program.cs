﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine("Введите число a");
string answerA = Console.ReadLine();
int a = Convert.ToInt32(answerA);

Console.WriteLine("Введите число b");
string answerB = Console.ReadLine();
int b = Convert.ToInt32(answerB);

if (a == b * b)
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");