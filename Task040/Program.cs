/* Напишите программу, которая:
1. принимает на вход три числа
2. проверяет может ли существовать треугольник
    со сторонами такой длинны
(Теорема о неравенстве треугольника:
каждая сторона треугольника меньше суммы двух другиз сторон) */

int [] CreatArrayRndInt(int size, int min, int max)
{
    int [] array = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

bool CheckCondition (int [] array)
{
    return (array [0] < array [1] + array [2]
    && array [1] < array [0] + array [2]
    && array [3] < array [0] + array [1]);
}

int [] arr = CreatArrayRndInt(3, 1, 10);
PrintArray(arr);
bool res = CheckCondition(arr);
Console.WriteLine(res ? "Triangle exists" : "Triangle doesn't exist");