// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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

int[,] FillArrayX2IntZero(int rowMin, int rowMax)
{
    int m = new Random().Next(rowMin, rowMax);
    int n = new Random().Next(rowMin, rowMax);
    // Console.WriteLine($"m={m} n={n}");
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = 0;
        }
    }
    return arr;
}

void PrintArrayX2(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    Console.Write("№ |\t");
    for (int x = 0; x < column; x++)
    {
        PrintColorGreen($"{x}\t");
    }
    Console.WriteLine();
    for (int x = 0; x < column; x++)
    {
        Console.Write($"---------");
    }
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (j == 0)
            {
                PrintColorBlue($"{i} ");
                Console.Write("|\t");
            }
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("\n  |");
    }
    Console.WriteLine();
}

int[,] FillArrayX2IntSpriral(int[,] arr)
{

    int count = 1;
    int limitRight = arr.GetLength(1)-1;
    int limitLeft = 0;
    int limitUp = 0;
    int limitDown = arr.GetLength(0)-1;
    int start = 0;
    int row = start;
    int col = start;
    while (arr[row, col] == 0)
    {
        while (arr[row, col] == 0 && col < limitRight )
        {
            arr[row, col] = count;
            col++;
            count++;
        }
        while (arr[row, col] == 0 && row < limitDown)
        {
            arr[row, col] = count;
            row++;
            count++;
        }
        while (arr[row, col] == 0 && col > limitLeft)
        {
             arr[row, col] = count;
             col--;
             count++;
        }
        while (arr[row, col] == 0 && row > limitUp)
        {
             arr[row, col] = count;
             row--;
             count++;
        }
        limitRight--;
        limitDown--;
        limitLeft++;
        limitUp++;
        start++;
        row = start;
        col = start;
    }
    if(arr.GetLength(0)%2 != 0) arr[((arr.GetLength(0))/2),((arr.GetLength(1))/2)] = count++;
    //if(arr.GetLength(0)%2 != 0) arr[1,1] = 3/2;
    return arr;
}

Console.WriteLine("How long side of array do you wish?");
Console.Write("Enter a number: ");
int side = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArrayX2IntZero(side, side);
PrintColorRed("Array with spriral count:\n\n");
PrintArrayX2(FillArrayX2IntSpriral(array));


