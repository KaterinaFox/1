// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double XPoint(double k01, double b01, double k02, double b02)
{
    double x0 = (b02 - b01) / (k01 - k02);
    return x0;
}
double YPoint(double k01, double b01, double k02, double b02)
{
    double y0 = k01 * ((b02 - b01) / (k01 - k02)) + b01;
    return y0;
}
Console.WriteLine("Заданно линейное уравление функции y = k1 * x + b1");
Console.WriteLine("Введите переменную к1 =");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b1 =");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданно линейное уравление функции y = k2 * x + b2");
Console.WriteLine("Введите переменную к2 =");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b2 =");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = XPoint(k1, b1, k2, b2);
double y = YPoint(k1, b1, k2, b2);
Console.WriteLine($"Координаты точки пересечения графиков ({x} ; {y})");