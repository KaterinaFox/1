// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] RandomArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 99);
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

bool FindArrayNumber(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Введите число от -99 до 99");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i<array.Length; i++)
    {
        if (num == array[i]) return true;
    }
    return false;
}

int[] arr = RandomArray(4);
PrintArray(arr);
bool findArrayNumber = FindArrayNumber(arr);
Console.WriteLine(findArrayNumber ? "Да" : "Нет");

// int[] CreateArrayRndInt(int size, int min, int max)
// {
// int[] arr = new int[size];
// Random rnd = new Random();

// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(min, max + 1);
// }
// return arr;
// }

// void PrintArray(int[] arr)
// {
// Console.Write("[");
// for (int i = 0; i < arr.Length; i++)
// {
// if (i < arr.Length - 1)
// Console.Write($"{arr[i]}, ");
// else Console.Write($"{arr[i]}");
// }
// Console.WriteLine("]");
// }

// int[] array = CreateArrayRndInt(5, 0, 999);
// PrintArray(array);

// bool FindNumberArray(int[] arr, int numb)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// if (arr[i] == numb) return true;
// }
// return false;
// }

// Console.Write("Введите искомое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Заданное число присутствует в массиве?");
// Console.WriteLine(FindNumberArray(array, number) ? "да" : "нет");