// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] RandomAMatrix(int row, int columns, int min, int max)
{
    int[,] matrix = new int[row, columns];
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


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j],5} ");
            else Console.Write($" {matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] SortRowsElementsMatrix(int[,] matrix)
{
    int [] arr = new int [matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            arr[j] =matrix[i,j];
        }
        int[] array_sort = SortArray(arr);
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = array_sort[j];
        }
    }
    return matrix;
}
int[] SortArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
        return arr;
}


int[,] array2d = RandomAMatrix(4, 4, 1, 30);
PrintMatrix(array2d);
SortRowsElementsMatrix(array2d);
Console.WriteLine();
PrintMatrix(array2d);