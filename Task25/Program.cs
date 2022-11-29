// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;
while (numberB <= 0)
{
    Console.WriteLine("Введите число B:");
    numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB <= 0) Console.WriteLine("Число B некорректно");
}

int DegreeDigit(int a, int b)
{
    int num = a;
    for (int i = 1; i < b; i++)
    {
        num = num * a;
    }
    return num;
}
int degreeDigit = DegreeDigit(numberA, numberB);
Console.WriteLine($"Число A в степени В: {degreeDigit}");
