Console.Write("Введите любой число N: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int count = 1;
if(N == 0)
{
 Console.WriteLine("0");
}
else
{
while(count <= N )
{
    Console.WriteLine(Math.Pow(count, 2));
    count++;
}
}