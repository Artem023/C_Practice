/* Задайте двумерный массив 
1. размером m * n 
2. заполненный случайными целыми числами 
m = 3, n = 4.
   0   1   2   3
0: 1   4   8   19
1: 5  -2   33  -2
2: 77  3   8    1 */

int [,] CreatMatrixRndInt(int rows, int columns, int min, int max) // Добавляем запятую, чтобы обознач. двумерный массив
{                                                                 // 3 запятые - трехмерные массивы (1ч 03мин - объяснение)
    int [,] matrix = new int[rows, columns]; 
    Random rnd = new Random(); 

    for (int i = 0; i < matrix.GetLength(0); i++) // В первой строчке количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Во второй строке количество столбцов
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    } 
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 4}, "); //,4 - отступы
            else Console.Write($"{matrix[i, j], 4}");       
        }
        Console.WriteLine("]");

    }
}

int [,] res = CreatMatrixRndInt(10, 10, 0, 1);
PrintMatrix(res);
