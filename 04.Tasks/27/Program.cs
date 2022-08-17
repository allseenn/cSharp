Console.Write("Enter a number: ");
string? number = Console.ReadLine();
int sum = 0;
int error = 0;
for(int i = 0; i <= number.Length-1; i++) 
{
    if(number[i] == 45)
    {
        i++;
        sum = sum - (number[i]-48);
    }
    else if(number[i] < 57 && number[i] > 48 && number[i] != 45)
    {
        sum = sum + (number[i]-48);
    }
    else
    {
        error = 1;
    }
}
if(error == 0)
{
    Console.WriteLine(sum); 
}
else
{
    Console.WriteLine($"Error, {number} contains symbols!");
}