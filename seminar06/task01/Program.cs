// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void TeoremaTriangle(int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A)
        Console.Write($"Треугольник со сторонами A = {A}, B = {B}, C = {C} существует");
    else
        Console.Write($"Треугольник со сторонами A = {A}, B = {B}, C = {C} НЕсуществует");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetInfo("Введите сторону A: ");
int numB = GetInfo("Введите сторону B: ");
int numC = GetInfo("Введите сторону C: ");
TeoremaTriangle(numA, numB, numC);
