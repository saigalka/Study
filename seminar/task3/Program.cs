// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Напишите число от 1 до 7 : ");
int day = int.Parse(Console.ReadLine());

if (day == 1) Console.WriteLine("День недели - Понедельник");
if (day == 2) Console.WriteLine("День недели - Вторник");
if (day == 3) Console.WriteLine("День недели - Среда");
if (day == 4) Console.WriteLine("День недели - Четверг");
if (day == 5) Console.WriteLine("День недели - Пятница");
if (day == 6) Console.WriteLine("День недели - Суббота");
if (day == 7) Console.WriteLine("День недели - Воскресенье");

if (day > 8 || day < 1 ) Console.WriteLine($"{day} - Неверное число!!!");