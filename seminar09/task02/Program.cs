// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SummNumber(int num)
{
    if (num == 0)
        return num;
    else
        return SummNumber(num / 10) + (num % 10);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите N: ");
Console.WriteLine($"N = {num} -> [ {SummNumber(num)} ]");