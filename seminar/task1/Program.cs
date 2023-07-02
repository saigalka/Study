// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

int sqr1 = num1 * num1;
int sqr2 = num2 * num2;

if (num1 == sqr2) Console.WriteLine($"Первое число {num1} является квадратом ({sqr2}) второго числа {num2}");
    else Console.WriteLine($"Первое число {num1} НЕявляется квадратом ({sqr2}) второго числа {num2}");

if (num2 == sqr1) Console.WriteLine($"Второе число {num2} является квадратом ({sqr1}) первого числа {num1}");
    else Console.WriteLine($"Второе число {num2} НЕявляется квадратом ({sqr1}) первого числа {num1}");
    