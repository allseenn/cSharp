// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Enter A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum=1;
void A(int a)
{
    if (b==0) return;
    b--;
    sum = sum * a;
    A(sum);
   // Console.WriteLine(sum);
}
A(a);
Console.WriteLine(sum);