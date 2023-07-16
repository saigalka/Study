// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int SumNotEnumArray(int[] array)
{
    int summNotEnum = 0;
    for (int i = 1; i < array.Length; i = i + 2) // нечётная позиция == нечётный элемент массива
    {        
        summNotEnum += array[i];
    }
    return summNotEnum;
}


int[] GenNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(beginValue, endValue + 1);
    }
    return array;
}

int[] array = GenNewRandomArray(10, 0, 10);
Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {SumNotEnumArray(array)}");
