Console.Write("Введите любой число N: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
for(int count=1; count <= N; count++)
{
    Console.WriteLine(Math.Pow(count, 2));
}
