// Напишите программу, которая принимает на вход чтри числа и выдает максимальное из этих чисел.
int a = 0;
int b = 0;
int c = 0;
int max = a;
Console.WriteLine("Введите число a:");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите число b:");
int.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Введите число c:");
int.TryParse(Console.ReadLine(), out c);

if ((a > b) && (a > c)) max = a;
if ((b > a) && (b > c)) max = b;
if ((c > b) && (c > a)) max = c;

Console.WriteLine(max);