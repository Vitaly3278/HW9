// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int Number(int n)
{
    if (n == 0)
    {
        return 0;
    }
    Console.Write($" {n}");
    return Number(n - 1);
}

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Number(n);
