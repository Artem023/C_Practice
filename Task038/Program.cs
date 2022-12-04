// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] CreatArrayRndDouble (int size, int min, int max)
{
    double [] array = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        double num = rnd.NextDouble() * (max - min) + min; //Формула, чтобы получить числа в нужном диапазоне
        array[i] = Math.Round (num, 1); 
    }
    return array;
}

void PrintArray(double [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i ++)
    {
        if (i < array.Length - 1) Console.Write ($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Comparison(double [] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i]; 
    }
    return max - min;
}

Console.Write("Enter massive size: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value: ");
int maximum = Convert.ToInt32(Console.ReadLine());

double [] arr = CreatArrayRndDouble(number, minimum, maximum);
PrintArray(arr);

double result = Comparison(arr);
Console.Write($" --> {result}");