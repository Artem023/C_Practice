/* Задайте двухмерный массив
найдите сумму элементов, находящихся на главной диагонали
с индексами (0;0) (1;1) */

int[,] CreatMatrixRndInt(int rows, int columns, int min, int max) // Добавляем запятую, чтобы обознач. двумерный массив
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

void SumIndex(int [,] matrix)
{
    int sum = 0;
     for (int i = 0; i < matrix.GetLength(0); i++) // В первой строчке количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    Console.WriteLine(sum);
}

int[,] array2D = CreatMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine(" ");
SumIndex(array2D);