// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindNumberInMassive(int[,] massive, int num)
{
    string printFind = $"{num} -> ";
    bool count = false;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] == num)
            {
                if (!count)
                {
                    printFind += $"находится по координатам - [{i} , {j}]";
                    count = true;
                }
                else
                    printFind += $", [{i} , {j}]";
            }
        }
    }
    if (!count) printFind += "такого числа в массиве нет";
    if ((num / 10) < massive.GetLength(0) && num % 10 < massive.GetLength(1))
        printFind += $"\nпо координатам [{num.ToString()[0]} , {num.ToString()[1]}]"
                    + $" находится число - {massive[num / 10, num % 10]}.";
    else
        printFind += $"\nкоординаты [{num.ToString()[0]} , {num.ToString()[1]}]"
                        + $" не входят в диапазон текущего массива.";
    Console.WriteLine(printFind);
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
int number = GetInfo("Введите двухзначное число которое нужно найти: ");
int[,] massive = DoDoubleMassive(rows, columns, 0, 100);
PrintDoubleMassive(massive);
FindNumberInMassive(massive, number);