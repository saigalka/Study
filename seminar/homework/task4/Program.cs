// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] num = new int[3];
int max = 0;

for (int i = 0; i < 3; i++)
{
    Console.Write("Введите число: ");
    num[i] = int.Parse(Console.ReadLine());
    if (num[i] > max) max = num[i];
}
Console.WriteLine($"Максимальное из этих чисел - {max}.");

