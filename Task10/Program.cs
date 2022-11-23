// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigital(int number)
{
    int number1 = number / 100;
    int number3 = number % 10;
    int number2 = (number - number1 *100 - number3) / 10;
    return number2;
}
Console.WriteLine($"Вторая цифра числа {SecondDigital(num)}");