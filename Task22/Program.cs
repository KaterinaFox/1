// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int num = -1;
while (num<1)
{ 
Console.WriteLine("Введите число N");
num = Convert.ToInt32(Console.ReadLine());
if(num < 1) Console.WriteLine("Введены неверные данные");
}
void Square(int number)
{
       for(int i = 1; i <= number; i++)
    {
        Console.WriteLine($" {i}   | {i * i}");
    }
}
Square(num);
