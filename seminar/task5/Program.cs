// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int numn = 0 - num;

if (num < numn)
{
    for (int i = num; i <= numn ; i++)
    {
        Console.Write ($"{i} ");
    }
}
else 
{
    for (int i = numn; i <= num ; i++)
    {
        Console.Write ($"{i} ");
    }
}

