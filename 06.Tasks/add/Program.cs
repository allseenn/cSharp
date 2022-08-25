// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120
int Factorial(int n)
{
    if(n == 1 || n == 0) return 1;
    else return n * Factorial(n-1);
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial of {number} is {Factorial(number)}");