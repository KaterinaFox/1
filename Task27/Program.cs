// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigitalNumber(int number)
{
int memory = Math.Abs(number);
number = memory;
int sum =0;
while (number != 0)
{
    memory = memory % 10;
    number = number / 10;
    sum = sum + memory;
    memory = number;
}
return sum;
}
int sumDigitalNumber = SumDigitalNumber(num);
Console.WriteLine($"Сумма цифр числа равна: {sumDigitalNumber}");