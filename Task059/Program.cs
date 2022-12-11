/*  Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. */

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

int [] FindMinPosition(int [,] matrix)
{
    int [] array = new int[2];
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

int [,] CreatMatrixNewInt(int [,] matrix, int [] indexe)
{
    int [,] newMatrix = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (i != indexe[0] || j != indexe[1])
            {
                
            }
        }
    }
    return matrix;
}

int [,] matr = CreatMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matr);
