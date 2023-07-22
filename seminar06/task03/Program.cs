// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

string Fibonacci(int max)
{
    int first = 0;
    int second = 1;
    int third;
    string result = $"N = {max} -> {first} {second}";
    for(int n = 3; n <= max; n++)
    {
        third = second + first;
        first = second;
        second = third;
        result += $" {third}";
    }    
  return result;
}
 
int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInfo("Введите число: ");
string fib = Fibonacci(number);
Console.WriteLine(fib);


