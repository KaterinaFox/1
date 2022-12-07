// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int [] Fibonacci(int number)
{
int [] array = new int[number];
array[1]=1;
for (int i = 2; i < array.Length; i++)
{
    array[i]=array[i-1]+array[i-2];
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

Console.WriteLine("Введите число N");
int num  = Convert.ToInt32(Console.ReadLine());
int[] arr = Fibonacci(num);
PrintArray(arr, "[", "]");