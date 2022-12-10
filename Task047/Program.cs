/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Enter the value of the variable M (rows): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of the variable N (columns): ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] CreatMatrixRndInt (int rows, int columns, int min, int max)
{
    int [,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.WriteLine($"{matrix[i, j], 4}, ");
        }
    }
}

int [,] matr = CreatMatrixRndInt(m, n, 1, 100);
PrintMatrix(matr);