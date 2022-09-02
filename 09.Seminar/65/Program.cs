Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int m, int n)
{
    if(n >= m)
    {
        if(n == m)
        {
            return;
        }
        PrintNumbers(m, n-1);
        Console.Write($"{n} ");
    }
    else
    {
     if(n == m)
        {
            return;
        }
        PrintNumbers(m-1, n);
        Console.Write($"{n} ");
    }
    
}

PrintNumbers(m,n);