// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] CrossPoint(double k1, double k2, double b1, double b2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);               // X = (b2 - b1) / (k1 - k2)
    point[1] = k1 * (b2 - b1) / (k1 - k2) + b1;     //Y = k1 * (b2 - b1) / (k1 - k2) + b1
    return point;
}

double GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Есть уравнения двух прямых: \ny = k1 * x + b1 \ny = k2 * x + b2");
double k1 = GetInfo("Введите значение k1: ");
double b1 = GetInfo("Введите значение b1: ");
double k2 = GetInfo("Введите значение k2: ");
double b2 = GetInfo("Введите значение b2: ");
double[] point = CrossPoint(k1, k2, b1, b2);
System.Console.WriteLine($"Точка пересечения этих двух прямых [{point[0]}; {point[1]}]");
