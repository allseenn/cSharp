// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
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

int[,] FillArrayX2IntRand()
{
    int m = new Random().Next(3, 5);
    int n = new Random().Next(3, 5);
    // Console.WriteLine($"m={m} n={n}");
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
    return arr;
}

void PrintArrayX2(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    Console.Write("№ |  ");
    for (int x = 0; x < n; x++)
    {
        PrintColorGreen($"{x}   ");
    }
    Console.WriteLine();
    for (int x = 0; x < n; x++)
    {
        Console.Write($"-----");
    }
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0)
            {
                PrintColorBlue($"{i} ");
                Console.Write("|  ");
            }
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
} 

void PrintArrayX2DelLine(int[,] arr, int row, int col)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    Console.Write("№ |  ");
    for (int x = 0; x < n; x++)
    {
        PrintColorGreen($"{x}   ");
    }
    Console.WriteLine();
    for (int x = 0; x < n; x++)
    {
        Console.Write($"-----");
    }
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0)
            {
                PrintColorBlue($"{i} ");
                Console.Write("|  ");
            }
            if(row == i && col != j) PrintColorRed("----");
            else if(row != i && col == j) PrintColorRed("|  ");
            else if(row == i && col == j) PrintColorRed("+");
            else Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
} 


int FindMinInArrayX2(int[,] arr, out int row, out int col)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int min = int.MaxValue;
    row = 0;
    col = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if(arr[i,j] < min) 
            {
                min = arr[i,j];
                row = i;
                col = j;
            }
        }
    }
    return min;
}

int[,] array = FillArrayX2IntRand();
int row = 0;
int col = 0;
int minimum = FindMinInArrayX2(array, out row, out col);
PrintArrayX2(array);
PrintArrayX2DelLine(array, row, col);

