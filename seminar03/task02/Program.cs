// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double Lenght(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ax = GetInfo("Ведите координату х точки А: ");
int Ay = GetInfo("Ведите координату х точки А: ");
int Bx = GetInfo("Ведите координату х точки А: ");
int By = GetInfo("Ведите координату х точки А: ");

Console.WriteLine($"Расстояние между двумя точками на плоскомти равно {Lenght(Ax, Ay, Bx, By)}");
