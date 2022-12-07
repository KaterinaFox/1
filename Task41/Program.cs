// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] Insert(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
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

int CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер масссива");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Число не может быть отрицательным");
    return;
}
Console.WriteLine($"Введите {num} элементов масссива");
int[] arr = Insert(num);
PrintArray(arr, "[", "]");
Console.WriteLine($" ==> Количество чисел больше нуля = {CountElements(arr)}");