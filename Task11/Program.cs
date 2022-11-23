// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число  --> {number}");
int digitalOne = number / 100;
int digitalTwo = number % 10;
int result = digitalOne * 10 + digitalTwo;
Console.WriteLine($"Получилось число  --> {result}");

int RemoveSecondDigital(int num)
{
    int digitalOne = num / 100;
    int digitalTwo = num % 10;
    int result = digitalOne * 10 + digitalTwo;
    return result;
}
Console.WriteLine($"Получилось число  --> {RemoveSecondDigital(number)}");
