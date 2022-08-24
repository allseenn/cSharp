double k1, k2, b1, b2, x, y = 0;
Console.Write("Enter b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Match lines");
}
else if (k1 == k2)
{
    Console.WriteLine("Parallel lines");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"Cross point is ({x}, {y})");
}