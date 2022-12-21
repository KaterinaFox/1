// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] Binary(int numb)
{
int numb1 = numb;
int digits = 0;
while (numb1 > 0)
{
numb1 /= 2;
digits += 1;
}
int[] bin = new int[digits];
for (int i = 0; i < bin.Length; i++)
{
bin[bin.Length-i-1] = numb % 2;
numb /= 2;
}
return bin;
}
void PrintArray(int[] array, string symb1, string symb2)
{
    Console.Write(symb1);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(symb2);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
// Console.WriteLine(Binary(number));
PrintArray(binary, "", "", "");