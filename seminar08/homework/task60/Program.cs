// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool ifNumberExistsInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number)
                    return true;
            }
        }
    }
    return false;
}

void PrintTripleMassive(int[,,] massive)
{
    for (int k = 0; k < massive.GetLength(2); k++)
    {
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write($" {massive[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] DoTripleMassive(int numX, int numY, int numZ, int minValue = 0, int maxValue = 9)
{
    int[,,] result = new int[numX, numY, numZ];
    int number;
    for (int i = 0; i < numX; i++)
    {
        for (int j = 0; j < numY; j++)
        {
            for (int k = 0; k < numZ; k++)
            {
                while (result[i, j, k] == 0)
                {
                    number = new Random().Next(minValue, maxValue + 1);
                    if (!ifNumberExistsInArray(result, number))
                        result[i, j, k] = number;
                }
            }
        }
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numX = GetInfo("Введите X: ");
int numY = GetInfo("Введите Y: ");
int numZ = GetInfo("Введите Z: ");

int[,,] massive = DoTripleMassive(numX, numY, numZ, 10, 99);
PrintTripleMassive(massive);
System.Console.WriteLine();
