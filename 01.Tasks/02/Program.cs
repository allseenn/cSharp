Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{     
    Console.Write("max = ");
    Console.WriteLine(numberA);
}
if(numberA < numberB)
{     
    Console.Write("max = ");
    Console.WriteLine(numberB);
}
if(numberA == numberB)
{     
    Console.WriteLine("A = B");
}
