// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

void printPascal(int n)
{
    for (int line = 1; line <= n; line++)
    {
        int C = 1;
        for (int i = 1; i <= line; i++)
        {
            Console.Write(C + " ");
            C = C * (line - i) / i;
        }
        Console.Write("\n");
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countTriangle = GetInfo("Сколько строк треугольника Паскаля: ");
printPascal(countTriangle);

