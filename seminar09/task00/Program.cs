// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string WriteIntNumber(int num)
{
    if (num == 1)
        return "1";
    else
        return WriteIntNumber(num - 1) + ", " + num.ToString();
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите N: ");
Console.WriteLine($"N = {num} -> [ {WriteIntNumber(num)} ]");