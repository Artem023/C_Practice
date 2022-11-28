/* Напишите программу, которая:
1. выводит массив из 8 элементов, 
    заполненный 0 и 1 в случайном порядке */

int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);











/* int [] array = new int [8]; // - массив в основном используют его (сейчас он заполнен нулями)
/* int [] array1 = {1, 4, 5, 6, 8, 10}; // - массив со значениеся
int [] array2 = new int [5] {1, 2, 3, 4, 5}; // еще один вид записи массива */
/* 
array [0] = 345;
array [1] = 89;
array [2] = 56;
array [3] = 1000;
array [4] = 956;

for (int i = 1; i < array.Length; i ++)
{
    array [i] = i * i;
}

System.Console.WriteLine(array[0]); */

