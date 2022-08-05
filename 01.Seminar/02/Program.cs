Console.Write("Enter any numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter any numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;

if(numberA == square)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}