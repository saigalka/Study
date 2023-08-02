// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint funcAckermann(uint numM, uint numN)
{
    if (numM == 0)
        return numN + 1;
    else if (numM > 0 && numN == 0)
        return funcAckermann(numM - 1, 1);
    else if ((numM > 0) && (numN > 0))
        return funcAckermann(numM - 1, funcAckermann(numM, numN - 1));
    else
        return numN + 1;
}

uint GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToUInt32(Console.ReadLine());
}

uint numM = GetInfo("Введите число - M: ");
uint numN = GetInfo("Введите число - N: ");
Console.Write($"Функция Аккермана, m - {numM} и n - {numN}: A(m,n) = {funcAckermann(numM, numN)}");
