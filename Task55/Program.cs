// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
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
bool ChangeRowsColumns(int[,] matrix)
{
    int length = matrix.GetLength(1);
    if (length == matrix.GetLength(0))
    {
        int temp = 0;
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            for (int j = i+1; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
        return true;
    }
    else return false;
}

int[,] array2d = RandomAMatrix(4, 4, 0, 5);
PrintMatrix(array2d);
bool a = ChangeRowsColumns(array2d);
Console.WriteLine();
if (a == true)  PrintMatrix(array2d);
else Console.WriteLine($"количество строк и столбцов не равно");
