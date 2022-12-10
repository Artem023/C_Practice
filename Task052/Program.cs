/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Enter the number of the rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of the columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] CrearMatrixRndInt(int rows, int columns, int min, int max )
{
    Random rnd = new Random();
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.WriteLine($"{matrix[i, j]}, ");
        }
    }
}

void ArithmeticMean(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double result = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result = result + matrix[i, j];
        }
    
        result = result / (matrix.GetLength(1));
        result = Math.Round(result, 1);
        Console.Write($"{result}; ");
    }
}

int [,] mat = CrearMatrixRndInt(row, col, 1, 10);
PrintArray(mat);
ArithmeticMean(mat);