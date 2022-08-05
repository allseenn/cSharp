Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB && numberA > numberC)
{     
    Console.Write("max = ");
    Console.WriteLine(numberA);
}
if(numberB > numberA && numberB > numberC)
{     
    Console.Write("max = ");
    Console.WriteLine(numberB);
}
if(numberC > numberA && numberC > numberB)
{     
    Console.Write("max = ");
    Console.WriteLine(numberC);
}
if(numberA == numberB && numberA == numberC)
{     
    Console.WriteLine("A = B = C");
}
