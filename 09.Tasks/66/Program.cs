// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int SumLine(int m, int n)
{
    if(m > n) return 0;
    sum = sum + m;
    SumLine(m+1, n);
    return sum;
}

Console.WriteLine($"M = {m}; N = {n} -> {SumLine(m,n)}");