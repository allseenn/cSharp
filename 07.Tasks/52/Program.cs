// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int m = new Random().Next(3,10);
int n = new Random().Next(3,10);
int[,] arr = new int[m,n];
Console.Write("№ |\t");
for (int x = 0; x < n; x++)
{
    PrintColorGreen($"{x}\t");
}
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
            PrintColorBlue($"{i} ");
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
double sum = 0;
for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        sum = sum + arr[x,y];
        
    }
    PrintColorRed($"{Math.Round(sum/m,2)}\t");
    sum = 0;
}
Console.WriteLine();
