// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число A:");
int number = Convert.ToInt32(Console.ReadLine());
if(number<=0) Console.WriteLine("Неверные данные");
else
{
int i = 1;
int res = 1;
while (i<number)
{
    res = res + res * i;
    i++;   
}
Console.WriteLine($"Произведение чисел ==> {res}");
}