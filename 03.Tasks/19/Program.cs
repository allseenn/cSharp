Console.Write("Enter any 5-digits number: ");
string? number = Console.ReadLine();
number = number.Replace("-","");
if (number.Length == 5)
{
    Console.WriteLine((number[0] == number[4] && (number[1] == number[3]))?"Yes":"No");
}
else
{
 Console.WriteLine($"You entered {number.Length}-digits number!");
}