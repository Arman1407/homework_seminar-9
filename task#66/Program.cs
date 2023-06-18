// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int summaCifr(int m, int n) // a = 12345
{
if (m < n)
return m;
return summaCifr(m / 10) + m % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
//Console.WriteLine(summaCifr());


// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumRec(10)); // 55