// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] NewArray(int[] array)
{
    int size = array.Length;
    int new_size = size / 2 + ((size % 2 == 0) ? 0 : 1);
    int[] array1 = new int[new_size];
    for (int i = 0, j = size - 1; i < new_size; i++, j--)
    {
        if (i != j)
            array1[i] = array[i] * array[j];
        else
            array1[i] = array[i];
    }
    return array1;
}

int[] arr = RandomArray(5, -10, 10);
PrintArray(arr);
int[] arr2 = NewArray(arr);
Console.WriteLine();
PrintArray(arr2);

