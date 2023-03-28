// Напишите программу, которая на вход принимает два числа и выдает, какое больше, а какое меньше
int a;
int b;
Console.WriteLine ("Введите число a:");
Console.WriteLine ("Введите число b:");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
  if(a > b)
  {
    Console.WriteLine(a);
  }
  else if (b > a)
  {
    Console.WriteLine(b);
  }
  else if (a ==b )
  {
    Console.WriteLine ("Числа равны");
  }
}
else
{
  Console.WriteLine("Упс!Что-то пошло не так");
}