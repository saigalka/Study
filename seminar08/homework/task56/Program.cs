// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


int FindRowsMinSummElements(int[,] array)
{
    int summMin = int.MaxValue,
        columnsMin = 0,
        temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (summMin > temp)
        {
            summMin = temp;
            columnsMin = i;
        }
    }
    return columnsMin + 1;
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        Console.Write($"{i + 1} | ");
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($" {massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue = 0, int maxValue = 9)
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

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");

int[,] massive = DoDoubleMassive(rows, columns);
PrintDoubleMassive(massive);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindRowsMinSummElements(massive)} строка");