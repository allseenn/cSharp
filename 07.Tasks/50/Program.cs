// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Write("Enter row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column number: ");
int column = Convert.ToInt32(Console.ReadLine());
int[] result = {0,0};
int m = new Random().Next(3,10);
int n = new Random().Next(3,10);
int[,] arr = new int[m,n];
Console.Write("№ |");
Console.ForegroundColor = ConsoleColor.Green;
for (int x = 0; x < n; x++)
{
 Console.Write($"{x} ");
}
Console.ResetColor();
Console.WriteLine();
for (int x = 0; x < n; x++)
{
 Console.Write($"---");
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
            Console.Write("|");
        }
        
        if(i == row && j == column)
        { 
            result[0] = arr[i,j];
            result[1] = 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(arr[i,j] + " ");
            Console.ResetColor();
        }
        else Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
} 
Console.WriteLine();
if(result[1] == 1) 
{
    Console.Write($"Row ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(row);
    Console.ResetColor();
    Console.Write(" column ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(column);
    Console.ResetColor();
    Console.Write(" -> ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(result[0]);
    Console.ResetColor();
}
else 
{
        Console.Write($"Row ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(row);
    Console.ResetColor();
    Console.Write(" column ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(column);
    Console.ResetColor();
    Console.Write(" -> ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("No such element");
    Console.ResetColor();
}
