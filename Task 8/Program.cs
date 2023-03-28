// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
int i = 1;
System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

while(i <= N)
{
  if (i % 2 == 0)
 { 
  Console.WriteLine(i);
 }
 i++;
}
