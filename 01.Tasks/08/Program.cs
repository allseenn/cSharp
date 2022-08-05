Console.Write("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= number)
{
    Console.Write(count);
    if(count < number-1)
        Console.Write(",");
    count = count + 2;
}
Console.WriteLine();