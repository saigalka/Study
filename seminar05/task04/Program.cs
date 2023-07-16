// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] SummElementArray(int[] array)
{
    int[] newArray = new int[array.Length / 2 + 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
        newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
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

int[] array = GenNewRandomArray(7, 0, 10);
Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");

int[] newArray = SummElementArray(array);
Console.WriteLine("Новый массив - [" + string.Join(", ", newArray) + "]");


