/* Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования */

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

int [] CoppyArray (int [] array)
{
    int size = array.Length;
    int [] newArray = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        newArray [i] = array [i];
    }
    return newArray;
}   

int [] arr = CreatArrayRndInt(5, 0, 1000);
PrintArray(arr);
int [] newArr = CoppyArray(arr);
Console.Write(" ---> ");
PrintArray(newArr);