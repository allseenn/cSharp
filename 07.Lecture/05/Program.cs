
int[] ConvertFromDecimalToAny(int n, int l)
{
int[] arr = new int[l];
int delitel, vichitaemoe, ostatok;
for (int i = l-1; i >= 0; i--)
{
    delitel = n / l;
    vichitaemoe = delitel * l;
    ostatok = n - vichitaemoe;
    n = delitel;
    arr[i] = ostatok;
}
return arr;
}

char[] s = { 'а', 'в', 'и', 'с' };

int n = s.Length;
int m = (int)Math.Pow(s.Length, n);
//char [,] arr = new char [m,n];
int[] temp = new int[n];
for (int i = 0; i < m; i++)
{
    Console.Write($"{i}\t");
    temp = ConvertFromDecimalToAny(i, n);
    for (int j = 0; j < n; j++)
    {
        //arr[i,j] = s[temp[j]];
        //Console.Write(arr[i,j]); 
        Console.Write(s[temp[j]]); 
    }
    Console.WriteLine();
}