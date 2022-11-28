/* Найти произведение пар числе в массиве
Например [1, 2, 3, 4] = 1*4 2*3 */

int [] CreatArrayRndInt (int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] TaskSolution(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size +=1;
    int[] multiArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        multiArray[i] = array[i] * array[array.Length - i - 1];
    }
    return multiArray;
}

int [] arr = CreatArrayRndInt (5, 1, 10);
PrintArray(arr);
int [] result = TaskSolution(arr);
PrintArray(result);
