//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Stepen (int numberA, int numberB)
{
    int num = 1;
    while (numberB > 0)
    {
        num = num * numberA;
        numberB--;
    }
    return num;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetInfo("Введите число А: ");
int numB = GetInfo("Введите число В: ");

Console.WriteLine($"Число А {numA} в натуральной степени B {numB} - {Stepen(numA, numB)}");