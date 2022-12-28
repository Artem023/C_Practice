/* Напишите программу, которая 
найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("k1 * x + b1, y = k2 * x + b2");
Console.Write("Enter B1 value: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter K1 value: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B2 value: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter K2 value: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double [] PointCoordinates(double B1, double K1, double B2, double K2)
{
    double [] result = new double [2];
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 2);
    double y = x;
    result[0] = x;
    result[1] = y;
    return result;

    // Console.Write($"({x}, {y})");
}

double [] res = PointCoordinates(b1, k1, b2, k2);
Console.Write(res);
