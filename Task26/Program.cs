// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число A:");
int number = Convert.ToInt32(Console.ReadLine());

int LongDigital (int num)
{
int i = 0;
while (num != 0)
{
    num = num / 10;
    i++;
}    
return i == 0 ? 1 : i;
}
int longDigital = LongDigital (number);
Console.WriteLine($"Длинна числа {number} = {longDigital}");