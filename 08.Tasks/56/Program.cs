// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
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

int[,] FillArrayX2IntRand(int rowMin, int rowMax, int digitMin, int digitMax, out int minLine, out int sum)
{
    int m = new Random().Next(rowMin, rowMax);
    int n = new Random().Next(rowMin, rowMax);
    int[,] arr = new int[m, n];
    int[] line = new int[n];
    sum = int.MaxValue;
    minLine = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(digitMin, digitMax);
            line[j] = arr[i,j];
        } 
        if(sum > Sum(line))
        {
            sum = Sum(line);
            minLine = i;
        }
    }
    return arr;
}

void PrintArrayX2(int[,] arr, int minLine)
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
            if(minLine == i) PrintColorRed(arr[i, j] + " ");
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int minLine;
int sum;
int[,] array = FillArrayX2IntRand(3,10,0,9, out minLine, out sum);

PrintArrayX2(array, minLine);

PrintColorBlue($"Line {minLine} ");
Console.Write("has minimal summa:");
PrintColorRed($" {sum}");

