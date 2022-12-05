//  Задача 38. Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}
void PrintArray(double[] array, string symb1, string symb2)
{
    Console.Write(symb1);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(symb2);
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return Math.Round(max - min, 1);
}

double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArray(arr, "[", "]");
double diffMaxMin = DiffMaxMin(arr);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diffMaxMin}");