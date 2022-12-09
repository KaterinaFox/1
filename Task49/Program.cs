// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


int[,] ChangElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            if (i % 2 ==0 && j % 2 == 0)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
        return matrix;
}

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
                if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j],5}, ");
                else Console.Write($" {matrix[i, j],5} ");
            }
            Console.WriteLine("|");
        }
    }
    int[,] array2d = RandomAMatrix(4, 4, 0, 10);
    PrintMatrix(array2d);
    ChangElements(array2d);
    Console.WriteLine();
    PrintMatrix(array2d);