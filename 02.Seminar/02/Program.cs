int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number: {number}");
int digit1 = number / 100;
int digit2 = number % 10;
Console.WriteLine(digit1*10+digit2);