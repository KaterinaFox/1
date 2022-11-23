// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Clear();
Console.WriteLine("Напишите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
return (num1==num2*num2) || (num2==num1*num1) ;
}
bool res = Square(a, b);
Console.WriteLine(res ? "Да" : "Нет");
