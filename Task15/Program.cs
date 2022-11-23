// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели ");
int numday = Convert.ToInt32(Console.ReadLine());

int Holidays(int day)
{
    if (day == 6 || day == 7) return 1;
    else if (day > 0 && day < 6) return 0;
    else return -1;
}

int holiday = Holidays(numday);
if (holiday == 1)
    Console.WriteLine("Да");
else if (holiday == 0)
    Console.WriteLine("Нет");
else
    Console.WriteLine("Такого дня недели нет");