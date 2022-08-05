Console.Write("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Its Masha!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}