﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


using static System.Console;
Console.Write("Введите число a:  ");
int a = Convert.ToInt32(ReadLine());
if (a % 2 == 1 || a % 2 == -1)
{
    WriteLine("Число a является нечетным!");
}
else
{
    WriteLine("Число а является четным!");
}