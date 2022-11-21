/* Напишите программу, которая:
1. принимает на вход координаты двух точек
2. находит расстояние между ними в 2D пространстве */

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Length(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt((xb - xa) * (xb - xa)
            + (yb - ya) * (yb - ya));

}
double result = Math.Round(Length(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(result);