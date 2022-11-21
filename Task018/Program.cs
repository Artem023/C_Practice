/* Напишите программу, которая:
1. по заданному номеру
2. показывает диапозон возможных координат точек в этой четверти */

Console.WriteLine("Введите номер четверти: ");
string quarterNumber = Console.ReadLine();

string Range(string num)
{
    if (num == "1") return "x > 0 и y > 0";
    if (num == "2") return "x < 0 и y > 0";
    if (num == "3") return "x < 0 и y < 0";
    if (num == "4") return "x > 0 и y < 0";
    return "Введены некотректные данные";
}

string result = Range(quarterNumber);
Console.WriteLine(result);

/* Console.WriteLine (Math.Sqrt(25)); // Извлекает квадратный корень
double n = 5.099346678; // double - дробные числа
double res = Math.Round(n, 2, MidpointRounding.ToZero); // Math.Round(число, до какого знака,стратегия округления (в большую или меньшу сторону округляем)) округляет числа 
Console.WriteLine(res); */