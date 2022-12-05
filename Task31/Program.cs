// Задача 31: 
// 1. Задайте массив из 12 элементов 
// 2. Заполните случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.Write("]");
}
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

int GetSumNegativ(int[] arr)
{
    int sumNegativ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegativ += arr[i];
    }
    return sumNegativ;
}

int GetSumPositiv(int[] arr)
{
    int sumPositiv = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositiv += arr[i];
    }
    return sumPositiv;
}
int sumNegativ = GetSumNegativ(array);
int sumPositiv = GetSumPositiv(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных {sumPositiv}, Сумма отрицательных {sumNegativ}.");