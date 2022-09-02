// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Qui(int n)
{
    if(n == 0) return;
    if(n == 1) Console.Write($"{n}\"");
    else Console.Write($"{n}, ");
    Qui(n-1);
}

Console.Write($"N = {number} -> \"");
Qui(number);