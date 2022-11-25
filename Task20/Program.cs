// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А ");
Console.Write("Х= ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("Х= ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int a, int b, int c, int d)
{
    double s1 = a - c;
    double s2 = b - d;
    double sum = s1 * s1 + s2 * s2;
    double res = Math.Sqrt(sum);
    double resultRound = Math.Round(res, 2, MidpointRounding.ToZero);
    return resultRound;
}

double distance = Distance(x1, y1, x2, y2);
Console.WriteLine($"Дистанция между точками А и В = {distance}");
