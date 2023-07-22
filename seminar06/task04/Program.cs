//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] ReversedArray(int[] arr)
{
    int[] temp = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        temp[i] = arr[i];
    }
    return temp;
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

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInfo("Введите размер массива: ");
int[] array = GenNewRandomArray(number, 1, 99);
Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");
int[] copyArray = ReversedArray(array);
Console.WriteLine("Копия массива - [" + string.Join(", ", copyArray) + "]");