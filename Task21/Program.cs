// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А ");
Console.Write("Х= ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z= ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("Х= ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y= ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z= ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double s1 = bx - ax;
    double s2 = by - ay;
    double s3 = bz - az;
    double sum = s1 * s1 + s2 * s2 + s3 * s3;
    double res = Math.Sqrt(sum);
    double resultRound = Math.Round(res, 2, MidpointRounding.ToZero);
    return resultRound;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Дистанция между точками А и В = {distance}");
