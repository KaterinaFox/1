// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Clear();
Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0) 
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"НЕ кратно, остаток {a%b}");

bool Multiplicity(int num1, int num2)
{
if (num1%num2==0) return true;
return false;
}
bool result = Multiplicity(a,b);
Console.WriteLine(result ? "Кратно" : $"Не кратно, остаток {a%b}");
