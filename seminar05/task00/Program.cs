// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.


int GetPosOrNegSum(int[] array, bool posOrNeg)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (posOrNeg)
        {
            if (array[i] > 0)
                summ += array[i];
        }
        else
            if (array[i] < 0)
                summ += array[i];
    }
    return summ;
}

int[] GenNewRandomArray(int size, int beginValue, int endValue)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(beginValue, endValue);
    }
    return Array;
}

int[] array = GenNewRandomArray(12, -9, 9);

Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма положительных {GetPosOrNegSum(array, true)}, сумма отрицательных {GetPosOrNegSum(array, false)}");