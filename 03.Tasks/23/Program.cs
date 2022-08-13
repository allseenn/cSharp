Console.Write("Введите любой число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if( N>=0 )
{
    for(int count=1; count <= N; count++)
    {
        Console.WriteLine(Math.Pow(count, 3));
    }
}
else 
{
   for(int count=-1; count > N; count--)
    {
        Console.WriteLine(Math.Pow(count, 3));
    }
}