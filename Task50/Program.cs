// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] RandomAMatrix(int row, int colums, int min, int max)
{
    int[,] matrix = new int[row, colums];
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
bool FindElement(int[,] matrix, int a1, int b1)
{
    if (a1 >= 0 && a1 < matrix.GetLength(0) && b1 >= 0 && b1 < matrix.GetLength(1))
        return true;
    else
        return false;
}
int[,] array2d = RandomAMatrix(4, 4, 0, 10);
PrintMatrix(array2d);

Console.WriteLine();
Console.WriteLine($"Введите номер строки матрицы");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите номер столбца матрицы");
int b = Convert.ToInt32(Console.ReadLine());
bool findElement = FindElement(array2d, a, b);
Console.WriteLine(findElement ? $"Искомый элемент матрицы = {array2d[a, b]}"
: "Такого элемента в массиве нет");