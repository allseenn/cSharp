// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiply(int[,] array1, int[,] array2) 
{  
    int array1Rows = array1.GetLength(0);
    int array1Cols = array1.GetLength(1);
    int array2Rows = array2.GetLength(0);
    int array2Cols = array2.GetLength(1);
    int[,] arr = new int[array1Rows, array2Cols];
    
    for (int array1_row = 0; array1_row < array1Rows; array1_row++) 
    {
        for (int array2_col = 0; array2_col < array2Cols; array2_col++) 
        {  
            for (int array1_col = 0; array1_col < array1Cols; array1_col++) 
            {
                arr[array1_row, array2_col] +=
                array1[array1_row, array1_col] *
                array2[array1_col, array2_col];
            }  
        }  
    }  
  
    return arr;
}  
Console.WriteLine("How long side of matrix do you wish?");
Console.Write("Enter a number: ");
int side = Convert.ToInt32(Console.ReadLine());
int[,] array1 = FillArrayX2IntRand(side,side,0,9);
int[,] array2 = FillArrayX2IntRand(side,side,0,9);
PrintColorRed("\nFirst matrix\n\n");
PrintArrayX2(array1);
PrintColorRed("Second matrix\n\n");
PrintArrayX2(array2);
PrintColorRed("Multiplied matrix\n\n");
PrintArrayX2(Multiply(array1, array2));
