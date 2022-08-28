// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void PrintColorGreen(string print)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(Convert.ToString(print));
    Console.ResetColor();
}

void PrintColorBlue(string print)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(Convert.ToString(print));
    Console.ResetColor();
}

void PrintColorRed(string print)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(Convert.ToString(print));
    Console.ResetColor();
}

Console.Write("Enter row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column number: ");
int column = Convert.ToInt32(Console.ReadLine());
int[] result = {0,0};
int m = new Random().Next(3,10);
int n = new Random().Next(3,10);
int[,] arr = new int[m,n];
Console.Write("№ |");
for (int x = 0; x < n; x++)
{
    PrintColorGreen($"{x} ");
}
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
            PrintColorBlue($"{i} ");
            Console.Write("|");
        }
        
        if(i == row && j == column)
        { 
            result[0] = arr[i,j];
            result[1] = 1;
            PrintColorRed(arr[i,j] + " ");
        }
        else Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
} 
Console.WriteLine();
if(result[1] == 1) 
{
    PrintColorBlue($"Row {row}");
    PrintColorGreen($" column {column}");
    Console.Write(" ->");
    PrintColorRed($" {result[0]}");
}
else 
{
    PrintColorBlue($"Row {row}");
    PrintColorGreen($" column {column}");
    Console.Write(" ->");
    PrintColorRed(" No such elements");
}
