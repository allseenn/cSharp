// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Write("Quantaty of numbers to show from fibanacci: ");
int number = Convert.ToInt32(Console.ReadLine());
int perv = 1;
int vtor = 1;
int sum = 0;
if(number > 0) Console.Write($"{sum} ");
if(number > 1) Console.Write($"{perv} ");
if(number > 2) Console.Write($"{vtor} ");
for(int i = 0; i < number-3; i++)
{
    sum = perv + vtor;
    Console.Write($"{sum} ");
    perv = vtor;
    vtor = sum;
}
