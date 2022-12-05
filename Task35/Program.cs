// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] RandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int CountDigit(int[] array)
{
    
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=10 && array[i]<=99) count++;
    }
    return count;
}


int[] arr = RandomArray(123, -200, 200);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"{CountDigit(arr)}");