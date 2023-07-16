// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] DiffMinMaxArray(double[] array)
{
    double[] diffArray = new double[3];
    diffArray[0] = array[0];        //минимальный
    diffArray[1] = array[0];        //максимальный

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > diffArray[1]) diffArray[1] = array[i];
        if (array[i] < diffArray[0]) diffArray[0] = array[i];                
    }
    diffArray[2] = diffArray[1] - diffArray[0];
    return diffArray;
}

double[] GenNewRandomArray(int size, float endValue)
{
    double[] array = new double[size];
    Console.Write($"Массив из {size} элементов - [");
    for (int i = 0; i < size-1; i++)
    {
        array[i] = new Random().NextDouble() * 100;
        Console.Write($"{array[i]:0.00} ; ");
    }
    array[size-1] = new Random().NextDouble() * 100;
    Console.WriteLine($"{array[size-1]:0.00}]");
    return array;
}

double[] array = GenNewRandomArray(10, 100);
double[] diff = DiffMinMaxArray(array);
Console.WriteLine($"Минимальный элемент массива - {diff[0]:0.00}]");
Console.WriteLine($"Максимальный элемент массива - {diff[1]:0.00}]");
Console.WriteLine($"Разница между ними - {diff[2]:0.00}]");
