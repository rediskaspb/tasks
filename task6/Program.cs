﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
int mod = a % 2;
// Console.WriteLine(mod);
if (mod==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}