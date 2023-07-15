// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenArray(int num)
{
    int[] Array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Array[i] = new Random().Next(100);
    }
    return Array;
}

Console.Write("Массив из 8 элементов - [" + string.Join(", ", GenArray(8)) + "]");    
