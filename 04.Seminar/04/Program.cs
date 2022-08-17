Console.Write("Введите число N: ");

int number = Convert.ToInt32(Console.ReadLine());
int sum = number;
if(number >= 0)
{
for(int i = 1; i < number; i++)
{
    sum = i * sum;
}
Console.WriteLine(sum);
}
else 
{
   for(int i = -1; i > number; i--)
{
    sum = i * sum;
}
Console.WriteLine(sum); 
}