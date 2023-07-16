// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
//  и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] ArrayRevers (int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
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

int[] array = GenNewRandomArray(10, -9, 9);

Console.WriteLine("Массив - [" + string.Join(", ", array) + "]");

Console.WriteLine("Массив перевёрнутый - [" + string.Join(", ", ArrayRevers(array)) + "]");
