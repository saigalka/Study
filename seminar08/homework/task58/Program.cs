// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Произведение двух матриц выполнимо только в случае, 
// если количество столбцов левой матрицы равно количеству строк правой.

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (var i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
                for (var k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }
    else
        Console.WriteLine("\nУмножение не возможно!" +
        "\nКоличество столбцов первой матрицы не равно количеству строк второй матрицы.");
    return matrixC;
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
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

int rows = GetInfo("Введите количество строк матриц: ");
int columns = GetInfo("Введите количество столбцов матриц: ");
int[,] massiveA = DoDoubleMassive(rows, columns);
int[,] massiveB = DoDoubleMassive(rows, columns);
System.Console.WriteLine("\nЛевая матрица А:");
PrintDoubleMassive(massiveA);
System.Console.WriteLine("\nПравая матрица В:");
PrintDoubleMassive(massiveB);
int[,] resultC = MatrixMultiply(massiveA, massiveB);
System.Console.WriteLine("\nРезультирующая матрица C:");
PrintDoubleMassive(resultC);