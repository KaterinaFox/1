// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] Matrix(int row, int colums, int min, int max)
{
    int[,] matrix = new int[row, colums];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++)
    {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i,j],5}, ");
            else Console.Write($" {matrix[i,j],5} ");
    }
        Console.WriteLine("|");
}
}
int[,] array2d = Matrix(3, 4, -50, 50);
PrintMatrix(array2d);