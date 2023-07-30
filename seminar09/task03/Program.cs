// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SqrtNum(int numA, int numB, int result = 1)
{
    if (numB == 0)
        return result;
    else
    {
        result = result * numA; 
        return SqrtNum(numA, numB -1, result);  
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetInfo("Введите большее число - A: ");
int numB = GetInfo("Введите меньше число - B: ");
Console.WriteLine($"A = {numA}; B = {numB} -> [ {SqrtNum(numA, numB)} ]");