// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] RandomArr(int length, int min, int max)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

int [] CopyArr (int[] arr)
{
int [] arr1 = new int[arr.Length];
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i]=arr[i];
}
return arr1;
}

void PrintArray(int[] array, string symb1, string symb2)
{
    Console.Write(symb1);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(symb2);
}

int[] array = RandomArr(6,-10,10);
PrintArray(array, "[", "]");
int[]array1 = CopyArr (array);
PrintArray(array1, "[", "]");
