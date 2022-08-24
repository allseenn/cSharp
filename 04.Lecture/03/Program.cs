int Factorial(int n)
{
    if(n == 1 || n == 0) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(0));
