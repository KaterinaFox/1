// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigitalNumber(int number)
{
if (number != 0)
{
    return number% 10 + SumDigitalNumber (number / 10);
    //return number != 0 ? number % 10 + SumDigitalNumber(number / 10) : 0;
}
return 0;
}
int sumDigitalNumber = SumDigitalNumber(num);
Console.WriteLine($"Сумма цифр числа равна: {sumDigitalNumber}");