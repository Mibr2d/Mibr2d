﻿// 2. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
int d1 = number / 10;
int d2 = number % 10;
Console.WriteLine($"Случайное числа в {number}");
if (d1 > d2)
{
    Console.WriteLine($"Больше {d1}");
}
else
{
    Console.WriteLine($"Больше {d2}");
}
