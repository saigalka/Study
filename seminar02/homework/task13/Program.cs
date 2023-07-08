// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string num1 = Console.ReadLine();

// с помощью строки
if (num1.Length > 2)
{
    Console.WriteLine($"(string) У числа {num1}, третья цифра {num1[2]}");
}
else 
{
    Console.WriteLine($"(string) У числа {num1} третьей цифры нет");
}

// операции с числами
int num2 = int.Parse(num1);
int numDop = num2;
if (numDop > 999)
{
    while ( numDop > 999)
    {
        numDop = numDop / 10;
    }

    Console.WriteLine($"У числа {num2}, третья цифра {numDop % 10}");
}
else 
{
    if (num2 > 99)
    {
        Console.WriteLine($"У числа {num2}, третья цифра {num2 % 10}");
    }
    else
    {
        Console.WriteLine($"У числа {num2} третьей цифры нет");
    }
}