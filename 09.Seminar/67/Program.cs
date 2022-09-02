// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum=0;
void a(int n)
{
    if (n==0) return;
    sum=sum+n%10;
    a(n/10);
   // Console.WriteLine(sum);
}
a(n);
Console.WriteLine(sum);