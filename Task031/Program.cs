/* 
1. Задать массив из 12 элементов,
2. заполненный случайноыми числами из промежутка [-9 ; 9]
3. вывод массива
4. Найти сумму положительных и отрицательных элементов
 */

int [] CreatArrayRndInt(int size, int min, int max)
{
    int [] array = new int[size]; // new - в опер памяти выделяется новое место под переменную
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int GetSumPositiveElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;

}

int GetSumNegativeElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;

}

int[] arr = CreatArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);
Console.WriteLine($"Сумма положительных числе = {sumPositive} ");
Console.WriteLine($"Сумма отрицательных числе = {sumNegative} ");