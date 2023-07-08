// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

bool sravni = (num % 7 == 0) && (num % 23 == 0);

if (sravni)
{
    Console.WriteLine($"Число {num} кратно одновременно и 7 и 23.");
}
else
{
    Console.WriteLine($"Число {num} НЕ кратно 7 и 23 одновременно.");
}
