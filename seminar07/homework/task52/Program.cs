// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] AverageNumber(int[,] averageNumbers)
{
    double[] result = new double[averageNumbers.GetLength(1)];
    for (int i = 0; i < averageNumbers.GetLength(1); i++)
    {
        for (int j = 0; j < averageNumbers.GetLength(0); j++)
        {
            result[i] += averageNumbers[j,i];
        }
        result[i] /= averageNumbers.GetLength(0);        
    }
    return result;
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

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");
int[,] massive = DoDoubleMassive(rows, columns, 0, 10);
PrintDoubleMassive(massive);
double[] averageArray = AverageNumber(massive);
Console.WriteLine($"Среднее арифметическое каждого столбца - [{string.Join("; ", averageArray):0.0}]");