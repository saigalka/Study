// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int DefQuarter(int xPoint, int yPoint)
{
    if(xPoint > yPoint & yPoint > 0) return 1;
    if(xPoint < yPoint & yPoint > 0) return 1;
    if(xPoint < yPoint & yPoint < 0) return 1;
    if(xPoint > yPoint & yPoint < 0) return 1;
    return 0;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int xPoint = GetInfo("ВВедите координату X: ");
int yPoint = GetInfo("ВВедите координату Y: ");
Console.WriteLine($"это {DefQuarter(xPoint,yPoint)} Четверть!");
