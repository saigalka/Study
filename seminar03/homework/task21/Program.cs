// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenght(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));    
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ax = GetInfo("Ведите координату x точки A: ");
int Ay = GetInfo("Ведите координату y точки A: ");
int Az = GetInfo("Ведите координату z точки A: ");
int Bx = GetInfo("Ведите координату x точки B: ");
int By = GetInfo("Ведите координату y точки B: ");
int Bz = GetInfo("Ведите координату z точки B: ");

Console.WriteLine($"Расстояние между двумя точками в 3D равно - {Lenght(Ax, Ay, Az, Bx, By, Bz):0.000}");

