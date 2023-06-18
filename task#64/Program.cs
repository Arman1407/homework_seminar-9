// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string printNumbers(int b, int a = 1)
{
if (a == b)
return $"{b}";
return $"{b}, " + printNumbers(b - 1, a);
}

Console.Clear();
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(b, 1));

