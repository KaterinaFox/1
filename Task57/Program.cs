// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
int[] MatrixToArray(int[,] matrix)
{
    int k = 0;
    int[] arr = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void CountValue(int[] arr)
{
    int count = 0;
    int num = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз ");
            count = 1;
            num = arr[i];
        }
    }   
    Console.WriteLine($"{num} встречается {count} раз ");
}

int[,] array2d = RandomAMatrix(4, 4, 0, 10);
PrintMatrix(array2d);
int[] array = MatrixToArray(array2d);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountValue(array);
