Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0 )
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {number1 % number2}");
}