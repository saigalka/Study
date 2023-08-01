// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] < 10)
                Console.Write($" 0{massive[i, j]} ");
            else
                Console.Write($" {massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassiveSpiral(int rows, int columns)
{
    int enumeration = 0,
        i = 0,
        j = 0;
    int[,] result = new int[rows, columns];
    while (enumeration < rows * columns)
    {
        result[i, j] = 1 + enumeration++;
        if (i <= j + 1 && i + j < columns - 1)
            j++;
        else
            if (i < j && i + j >= rows - 1)
                i++;
            else
                if (i >= j && i + j > columns - 1)
                    j--;
                else
                    i--;
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

int[,] massive = DoDoubleMassiveSpiral(rows, columns);
PrintDoubleMassive(massive);
System.Console.WriteLine();

