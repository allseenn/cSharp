Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int sum = 1, numberB = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < numberB; i++) sum = sum * numberA;
Console.WriteLine(sum);