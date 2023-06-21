// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void SumRec(int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма числел в промежутке от m до n = {sum}");
        return;
    }
    sum = sum + (m++);
    SumRec(m, n, sum);
}

Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
SumRec(m, n, 0);
