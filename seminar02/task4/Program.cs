// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

void sravni(int x, int y)
{

    if ((x * x == y) || (y * y == x))
    {
        Console.WriteLine($"{x} {y} -> да, является квадратом");
    }
    else
    {
        Console.WriteLine($"{x} {y} -> нет, НЕ является квадратом");
    }
}

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());


sravni(num1, num2);