int NumbersAboveZero()
{
Console.Write("Give a number or leave empty to exit: ");
var M = Console.ReadLine();
int count = 0;
if (!string.IsNullOrEmpty(M))
{
    count= count + NumbersAboveZero();
    if(Convert.ToInt32(M)> 0) count++;
}
return count;
}

Console.WriteLine($"{NumbersAboveZero()} numbers without zero.");
