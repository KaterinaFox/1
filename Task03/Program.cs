// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Clear();
Console.WriteLine("Введите номер дня недели ");
int numday = Convert.ToInt32(Console.ReadLine());
if(numday == 1) Console.WriteLine("Понедельник");
else if(numday == 2) Console.WriteLine("Вторник");
else if(numday == 3) Console.WriteLine("Среда");
else if(numday == 4) Console.WriteLine("Четверг");
else if(numday == 5) Console.WriteLine("Пятница");
else if(numday == 6) Console.WriteLine("Суббота");
else if(numday == 7) Console.WriteLine("Воскресенье");
else  Console.WriteLine("Такого дня недели нет");