﻿// 9. Напишите программу, которая 1)выводит
// случайное число из отрезка [10, 99] и 2) показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
 Console.WriteLine($"Случайное число на отрезке от 10 до 99 --> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");
// }

int MaxDigit(int num)
{
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit) return firstDigit;
else return secondDigit;
// int max = firstDigit > secondDigit ? firstDigit : secondDigit;
// return max;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Максимальное число --> {maxDigit}");