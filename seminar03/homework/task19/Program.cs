// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int number)
{    
    if (number.ToString().Length == 5)                              //if (number > 9999 & number < 100000)
        if (((number / 10000) == (number % 10)) & ((number / 1000 % 10) == (number / 10 % 10)))
            Console.WriteLine($"Это пятизначное число {number} является палиндромом.");
        else        
            Console.WriteLine($"Это пятизначное число {number} НЕявляется палиндромом.");
    else
        Console.WriteLine("Неверное число");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите пятизначное число: ");
Palindrom(num);