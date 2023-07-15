// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");

Console.WriteLine($"Сумма цифр в числе {num} равна {Summa(num)}");