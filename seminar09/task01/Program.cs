// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string WriteIntNumber(int numN, int numM)
{
    if (numN == numM)
        return numM.ToString();
    else
        return WriteIntNumber(numN - 1, numM) + ", " + numN.ToString();
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numN = GetInfo("Введите большее число - N: ");
int numM = GetInfo("Введите меньше число - M: ");
Console.WriteLine($"M = {numM}; N = {numN} -> [ {WriteIntNumber(numN, numM)} ]");
