﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");

string? num1 = Console.ReadLine();
Console.WriteLine($"Первый вариант: Второй символ - {num1[1]} из числа {num1}"); // Показываем второй символ из строки

int num2 = int.Parse(num1);
Console.WriteLine($"Второй вариант: Второй символ - {(num2/10%10)} из числа {num2}"); 

