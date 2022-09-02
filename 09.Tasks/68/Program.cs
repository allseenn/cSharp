// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkerMan(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AkkerMan(m - 1, 1);
    else
        return AkkerMan(m - 1, AkkerMan(m, n - 1));
}

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AkkerMan(m, n)}");