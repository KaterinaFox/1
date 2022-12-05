// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = {-4, -8, 8, 2};


void ChangeArr (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.Write("]");
}

ChangeArr(array);

PrintArray(array);


