// Задача 0. Напишите число, которое на вход принимает число и выдает его квадрат
// (число умноженное само не себя).
// Например:
//  4 -> 16
//  -3 -> 9
//  -7 -> 49
Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
// string strNum = Console.ReadLine(); (строчку 8 можно двуми строками)
// int number = Convert.ToInt32(strNum); 
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");
