// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine ("Введите целое натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите целое натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumber (numberM, numberN);

void NaturalNumber (int numA, int numB)
{
if (numB > numA)  
{
    NaturalNumber (numA, numB-1);
    Console.Write ($"{numA}");
}
if (numB < numA) 
{
    Console.Write ($"{numB}");
    NaturalNumber (numA, numB+1);
}
if (numB == numA) 
{
    Console.Write ($"{numB}");
}
}
