// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetNum (int num)
{
    if (num < 0) 
    {
        num = num * (-1);
    }

    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }    
    return count;
}


int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInfo("Введите число: ");

Console.WriteLine($"Выводим количество цифр в числе {number} - {GetNum(number)}");


