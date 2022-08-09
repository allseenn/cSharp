int number = new Random().Next(10, 100);
Console.WriteLine($"Random number: {number}");
int ditig1 = number / 10;
int digit2 = number % 10;
if (ditig1 > digit2)
{
    Console.WriteLine(ditig1);
}
else 
{
    Console.WriteLine(digit2);
}