// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] MinElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] arr = new int[2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                arr[0] = i;
                arr[1] = j;
            }
        }
    }
    return arr;
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
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[,] ChangeMatrix (int [,] matrix, int[] arr)
{
        int row = matrix.GetLength(0)-1;
        int columns = matrix.GetLength(1)-1;
        int[,] matrix1 = new int [row, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != arr[0] && j !=arr[1])
            {
                int new_i = i < arr[0] ? i :  i-1;
                int new_j = j < arr[1] ? j : j-1;
                matrix1[new_i,new_j] = matrix[i, j];
            }
        }
    }
       return matrix1;
}
int[,] array2d = RandomAMatrix(4, 4, 1, 10);
PrintMatrix(array2d);
int[] array = MinElement(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int[,] array3d = ChangeMatrix(array2d, array);
PrintMatrix(array3d);