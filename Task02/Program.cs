// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if(a > b)
{
    max = a;
    Console.WriteLine("max = " + max);
}
else if(b > a)
{
    max = b;
    Console.WriteLine("max = " + max);
}
else Console.WriteLine("Числа равны, нет максимального");