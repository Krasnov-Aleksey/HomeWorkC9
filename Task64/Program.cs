//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

string f(int n)
{
  if (n== 1)
    return $"{n}";
  return $"{n}, "+f(n-1);
}

Console.Clear();
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));

