// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
Console.WriteLine("Введите число:");
int N = 0; 
if(int.TryParse(Console.ReadLine(), out N))
{
  if(N % 2 == 0)
  {
    Console.WriteLine("Число является четным");
  }
  else
  {
    Console.WriteLine("Число является нечетным");
  }
}
else
{
  Console.WriteLine("Упс! Что-то пошло не так");
}

