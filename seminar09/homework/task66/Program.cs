// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int WriteIntNumber(int numN, int numM)
{
    if (numN == numM)
        return numM;
    if (numN > numM)
        return WriteIntNumber(numN - 1, numM) + numN;
    else
        return WriteIntNumber(numM - 1, numN) + numM;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numM = GetInfo("Введите число - M: ");
int numN = GetInfo("Введите число - N: ");
Console.WriteLine($"Сумма элементов от M = {numM} до N = {numN} -> {WriteIntNumber(numN, numM)}");
