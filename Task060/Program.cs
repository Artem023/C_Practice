/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

int [,,] CreatMatrix3DRndInt(int rows, int columns, int depth, int min, int max)
{
    int [,,] matrix = new int [rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix [i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
           for (int k = 0; k < matrix.GetLength(2); k++)
           {    
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k], 1} (1-ый проход)| ");
                else Console.Write($" {matrix[i, j, k],4} (2-ой проход)| ");         
           }
        }
        Console.WriteLine();
    }
}

int [,,] matr = CreatMatrix3DRndInt(3, 3, 3, 1, 9);
PrintMatrix3D(matr);
 
 