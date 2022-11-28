/* Задайте массив 
программа определяет присутствет ли заданное число в массиве */

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] CreatArrayRndInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rnd = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool FindNumber (int[] array, int number)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
        res = true;
        break; // прерываем цикл, если находи тру
        }  
    }
    return res;
}

int [] arr = CreatArrayRndInt(5, -10, 15);
PrintArray(arr);
bool result = FindNumber(arr, num);
Console.Write(result ? "Yes" : "No");

