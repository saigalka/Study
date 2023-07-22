// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string StringBinary(int num)
{
    string result = string.Empty;
    string bin = string.Empty;
    int temp = num % 2;
    while (num >= 1)
    {
        temp = num % 2;
        bin = bin + Convert.ToString(temp);
        num /= 2;
    }
    for (int i = bin.Length; i > 0; i--)
    {
        result += bin[i-1];
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInfo("Введите число: ");
Console.Write($"{number} -> {StringBinary(number)}");

