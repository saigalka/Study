// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] DoDoubleMassiveSqrt(int[,] mass)
{
    for (int i = 1; i < mass.GetLength(0); i++)
    {
        for (int j = 1; j < mass.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                mass[i, j] = mass[i, j] * mass[i, j];
            }
        }
    }
    return mass;
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количкство строк массива: ");
int columns = GetInfo("Введите количкство строк массива: ");

int[,] massive = DoDoubleMassive(rows, columns, 0, 9);
PrintDoubleMassive(massive);
int[,] massiveSqr = DoDoubleMassiveSqrt(massive);
Console.WriteLine();
PrintDoubleMassive(massiveSqr);
