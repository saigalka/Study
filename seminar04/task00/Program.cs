// напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int limit)
{
    int sum =0;
    for (int i = 0; i <= limit; i++)
    {
        sum += i;

    }
    return sum;

}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInfo("Введите число А: ");

Console.WriteLine($"Сумма чисел от 1 до {num} равна {GetSum(num)}");
