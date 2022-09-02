// Дополнительные задания (необязательные)
// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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
            arr[i, j] = new Random().Next(20, 50);
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

void CountArrayDigsX2(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int[] arr1 = new int [m*n+1];
    arr1[m*n] = int.MaxValue;
    int countArr1 = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr1[countArr1] = arr[i,j];
            countArr1++;
        }
    }
    Array.Sort(arr1);
    int countDigs = 1;
    for (int k = 0; k < arr1.Length-1; k++)
    {
        if(arr1[k] == arr1[k+1]) 
        {
            countDigs++;
        }
        else if (arr1[k] != arr1[k+1])
        {
            if(countDigs > 1) PrintColorRed($"{arr1[k]} meets {countDigs} times\n");
            else Console.WriteLine($"{arr1[k]} meets {countDigs} times");
            countDigs = 1;
        } 
    }
}


int[,] array = FillArrayX2IntRand();
PrintArrayX2(array);
CountArrayDigsX2(array);
