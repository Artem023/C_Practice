﻿/* Задайте двумерный массив
напишите программу, которая
поменяет местами первую и последнюю строку массива */


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

void ChangeRows(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int [,] matr = CreatMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
ChangeRows(matr);
PrintMatrix(matr);
