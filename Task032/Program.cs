/* Напишите программу замена элементов массива: 
Изменить знак + на минус */

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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void NewArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = array [i] * (-1); 
    }
}

int [] arr = CreatArrayRndInt(15, -8, 15);
PrintArray(arr);

NewArray(arr);
PrintArray(arr);
