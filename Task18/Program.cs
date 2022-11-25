// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
int num = Convert.ToInt32(Console.ReadLine());

string Quater(int number)
{
    if(number ==1) return "x > 0 y > 0";
    if(number ==2) return "x < 0 y > 0";
    if(number ==3) return "x < 0 y < 0";
    if(number ==4) return "x > 0 y < 0";
    return "Введены некорректные данные";
}

string quater = Quater(num);
Console.WriteLine(quater);