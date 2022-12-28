/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Enter rows value: ");
int ro = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns value: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
    }
    
void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.WriteLine($"{matrix[i, j], 4}, ");
        }
    }
}
   
void PrintArray (int [] array)
{
    Console.Write($"(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}) ");
    }    
}
    
int [] FindRowSum (int [,] matrix)
{
    int [] array = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}
    
int FindMinNum (int [] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        for (int k = 1; k < array.Length; k++)
        {
            if (array[i] < array[k]) min = i;
        }
    }
    return min += 1;
}

if (ro != col)
{
    int [,] matr = CreatMatrixRndInt(ro, col, 1, 10);
    PrintMatrix(matr);
    Console.WriteLine(); 
    int [] arr = FindRowSum(matr);
    PrintArray(arr);
    Console.WriteLine();
    int result = FindMinNum(arr);
    Console.Write($"Наименьшая сумма находится в {result} строке");  
}
else Console.WriteLine($"Матрица не прямоугольная"); 

