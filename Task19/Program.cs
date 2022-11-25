// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите пятизначное число N");
int num = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(num) < 10000 || Math.Abs(num) > 99999)
    Console.WriteLine("Введены неверные данные");

bool Palindrome(int number)
{
    int memory = number;
    int rew = 0;
    while (memory != 0)
    {
        rew = rew * 10 + memory % 10;
        memory = memory / 10;
    }
    if (rew == number) return true;
    return false;
}
bool polindrom = Palindrome(num);
Console.WriteLine(polindrom ? "Да" : "Нет");
