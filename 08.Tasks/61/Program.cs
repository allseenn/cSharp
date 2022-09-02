// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

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

int[,] FillArrayX2IntZero(int row)
{
    int m = row;
    int n = row*2-1;
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
    Console.Write($"{'№',-2}|  ");
    for (int x = 0; x < column; x++)
    {
        PrintColorGreen($"{x,-3}");
    }
    Console.WriteLine();
    for (int x = 0; x < column; x++)
    {
        Console.Write($"{"---",-3}");
    }
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (j == 0)
            {
                PrintColorBlue($"{i,-2}");
                Console.Write("|  ");
            }
            if(arr[i,j] > 0) PrintColorRed($"{arr[i, j],-3}");
            else Console.Write($"{' ',-3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArrayX2Pascal(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        int[] line = PascalRowArrayX1(i, n);
        for (int j = 0; j < n; j++)
        {   
            arr[i,j] = line[j];
        }
    }
    return arr;
}

int[] PascalRowArrayX1(int N, int rowLen)
{
    int[] arr = new int[rowLen];
    // nC0 = 1
    int prev = 1;
    int center = rowLen/2-N;
    int space = center+2;
    arr[center] = prev;
    for(int i = 1; i <= N; i++)
    { 
        // nCr = (nCr-1 * (n - r + 1))/r
        int curr = (prev * (N - i + 1)) / i;
        arr[space] = curr;
        prev = curr;
        space = space+2;
    }
    return arr;
}

Console.Write("Pascals triangular, enter row N: ");
int pascalN = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArrayX2IntZero(pascalN);
int[,] pascal = FillArrayX2Pascal(array);
PrintArrayX2(pascal);
