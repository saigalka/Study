// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetPro(int number)
{
    int pro = 1;

    for (int i = 2; i <= number; i++)
    {
        pro = pro * i;
    }
    return pro;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число: ");
Console.WriteLine($"Произведение чисел от 1 до {num} равна {GetPro(num)}");