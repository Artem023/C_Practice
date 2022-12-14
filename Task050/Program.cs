/* Напишите программу, которая 
на вход принимает позиции элемента в двумерном массиве, 
возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет */

Console.Write("Enter the row value: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column value: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the row position: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column value: ");
int colPosition = Convert.ToInt32(Console.ReadLine());


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

void FindPosition(int [,] matrix, int rowPos, int colPos)
{
    if (rowPos <= matrix.GetLength(0) 
    && colPos <= matrix.GetLength(1))
    {
        Console.Write(matrix[rowPos, colPos]);
    }
    else Console.Write($"{rowPos}, {colPos} --> такого элемента не существует");
}

int [,] matr = CreatMatrixRndInt(str, col, 1, 10);
PrintMatrix(matr);
FindPosition(matr, rowPosition, colPosition);
