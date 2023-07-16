// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int CheckNumbersInArray(int[] array, int minNumber, int maxNumber)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > minNumber & array[i] < maxNumber)
            count++;            
    }
    return count;
}

int[] GenNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue);
    }
    return array;
}

int[] array = GenNewRandomArray(123, 0, 200);
Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");

Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] - ");
Console.WriteLine($"{CheckNumbersInArray(array, 10, 99)}.");
