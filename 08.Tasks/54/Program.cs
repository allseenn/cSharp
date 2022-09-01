// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

int[,] FillArrayX2IntRand(int rowMin, int rowMax, int digitMin, int digitMax)
{
    int m = new Random().Next(rowMin, rowMax);
    int n = new Random().Next(rowMin, rowMax);
    // Console.WriteLine($"m={m} n={n}");
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(digitMin, digitMax);
        }
    }
    return arr;
}

void PrintArrayX2(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    Console.Write("№ |");
    for (int x = 0; x < column; x++)
    {
        PrintColorGreen($"{x} ");
    }
    Console.WriteLine();
    for (int x = 0; x < column; x++)
    {
        Console.Write($"---");
    }
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (j == 0)
            {
                PrintColorBlue($"{i} ");
                Console.Write("|");
            }
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SortArray(int[] arr)
{
Array.Sort(arr);
Array.Reverse(arr);
return arr;      
}

int[,] SortLineOfArrayX2(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] line = new int[column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            line[j] = arr[i,j];
        }
        line = SortArray(line);
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = line[j];
        }
    }
    return arr;
}

int[,] array = FillArrayX2IntRand(3,10,0,9);
PrintColorRed("\nStright array\n\n");
PrintArrayX2(array);
PrintColorRed("Revers ordered by line array\n\n");
PrintArrayX2(SortLineOfArrayX2(array));
