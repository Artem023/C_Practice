/* Задайте одномерный массив из 123 случайных чисел
Найти количество элементов, которые лежат на отрезке [10, 99]*/

int [] CreatArrayRndInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] ");
}

int NumberOfElements(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99 ) result++;
    }
    return result;
}

int [] arr = CreatArrayRndInt(123, 0, 1000);
PrintArray(arr);

int res = NumberOfElements(arr);
Console.Write($"--> {res}");


