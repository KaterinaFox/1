// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 4(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



// int[,,] Random3Matrix(int row, int column, int depth)// более простой метод
// {
//     int[,,] matrix = new int[row, column, depth];
//     int[] arr = new int[row * column * depth];
//     for (int n = 0; n < arr.Length; n++) arr[n] = 10 + n;
//     int count = 0;
//     for (int k = 0; k < matrix.GetLength(2); k++)
//         for (int i = 0; i < matrix.GetLength(0); i++)
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrix[i, j, k] = arr[count];
//                 count++;
//             }
//     return matrix;
// }



bool IsUnique(int[] arr, int length, int value)
{
    for (int i = 0; i < length; i++)
        if (arr[i] == value)
            return false;
    return true;
}

int[,,] Random3Matrix(int row, int column, int depth, int min, int max)
{
    int[,,] matrix = new int[row, column, depth];
    int[] arr = new int[row * column * depth];
    int index = 0;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int value = rnd.Next(min, max + 1);
                bool notUnique = true;
                while (notUnique)
                {
                    notUnique = !IsUnique(arr, index, value);
                    if (notUnique)
                        value = rnd.Next(min, max + 1); ;
                }
                matrix[i, j, k] = value;
                arr[index] = value;
                index++;
            }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($" {matrix[i, j, k],1}({i},{j},{k})");
                else Console.Write($" {matrix[i, j, k],1}({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3d = Random3Matrix(3, 3, 3, 10, 99);
Console.WriteLine("");
Console.WriteLine("Трехмерная матрица:");
Console.WriteLine("");
PrintMatrix(array3d);
