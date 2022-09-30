// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumber(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine();
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {sum}");
        return n;
    }
    Console.Write($" {m}");
    sum = sum + (m++);
    return SumNumber(m, n, sum);
}

Console.Write("Введите m и n: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

SumNumber(m, n, 0);
