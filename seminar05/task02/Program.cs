// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

string CheckNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number || array[i] == -number)
            return "присутствует";
    }
    return "отсутствует";
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

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInfo("Введите число: ");
int[] array = GenNewRandomArray(10, -9, 9);
Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");

Console.WriteLine($"Результат проверки массива на приcутствие числа {number} - {CheckNumberInArray(array, number)}.");
