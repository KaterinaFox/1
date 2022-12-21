// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// double Faktorial(int n)
// {
// if (n==1)return 1;
// else
// return n*Faktorial(n-1);
// }

Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB <= 0) Console.WriteLine("Число B некорректно");


int DegreeDigit(int a, int b)
{
        if (b==1) return a; 
        else return a* DegreeDigit (a, b-1);
}
int degreeDigit = DegreeDigit(numberA, numberB);
Console.WriteLine($"Число A в степени В: {degreeDigit}");