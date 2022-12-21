// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine ("Введите целое натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите целое натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($" Сумма натуральных элементов = {NaturalSumNumbers (numberM, numberN)}");

int NaturalSumNumbers (int numA, int numB)
{
    if (numB > numA)  
        return numB + NaturalSumNumbers (numA, numB-1);;
    if (numB < numA) 
        return numB + NaturalSumNumbers (numA, numB+1);
    else 
        return numA;
}