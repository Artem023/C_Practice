/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Write("Enter rows value for the first matrix: ");
int firstRo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns value the first matrix: ");
int firstCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter rows value for the second matrix: ");
int secondRo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns value for the second matrix: ");
int secondCol = Convert.ToInt32(Console.ReadLine());
    
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

int [,] MatrixMulti(int [,] firstMatrix, int [,] secondMatrix)
{
    int [,] newMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                newMatrix[j, i] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return newMatrix;

}

if (firstRo == secondCol)
{
    Console.WriteLine("First matrix:");
    int [,] firstMatr = CreatMatrixRndInt(firstRo, firstCol, 1, 10);
    PrintMatrix(firstMatr);
    Console.WriteLine();
    Console.WriteLine("Second matrix:");
    int [,] secondMatr = CreatMatrixRndInt(secondRo, secondCol, 1, 10);
    PrintMatrix(secondMatr);
    Console.WriteLine();
    Console.WriteLine("New matrix:");
    int[,] newMatr = MatrixMulti(firstMatr, secondMatr);
    PrintMatrix(newMatr); 
}
else Console.WriteLine("Матрицу вычислить невозможно");


