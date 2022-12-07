// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// (Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон).



bool Triagnle(int a1, int b1, int c1)
{
return a1 < b1 + c1 && b1 < a1 + c1 && c1 < a1 + b1;
}

Console.WriteLine("Введите первую сторону треугольника");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triagnle(a, b, c) ? "Треугольник может существовать" : "Треугольник не может существовать");


// Console.WriteLine("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a>0 && b>0 && c>0)
// {
//     if (a+b>c && b+c>a && a+c>b)
//         {
//         Console.WriteLine("Треугольник с такими сторонами может существовать ");
//         }
// }
// else Console.WriteLine("Треугольника с такими сторонами существовать не может");
