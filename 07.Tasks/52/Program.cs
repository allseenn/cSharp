// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int m = new Random().Next(3,10);
int n = new Random().Next(3,10);
int[,] arr = new int[m,n];
Console.Write("№ |\t");
Console.ForegroundColor = ConsoleColor.Green;
for (int x = 0; x < n; x++)
{
    Console.Write($"{x}\t");
}
Console.ResetColor();
Console.WriteLine();
for (int x = 0; x < n; x++)
{
    Console.Write($"---------");
}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(0,10);
        if(j == 0) 
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{i} ");
            Console.ResetColor();
            Console.Write("|\t");
        }
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
} 
for (int x = 0; x < n; x++)
{
    Console.Write($"---------");
}
Console.WriteLine();
Console.Write("AV|\t");

Console.ForegroundColor = ConsoleColor.Red;
double sum = 0;
for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        sum = sum + arr[x,y];
        
    }
    Console.Write($"{Math.Round(sum/m,2)}\t");
    sum = 0;
}
Console.ResetColor();
Console.WriteLine();
 
