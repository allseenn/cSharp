// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
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
int[] RandList()
{
    int[]arr = new int[90];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i+10;
    }
    int temp;
    int k = 0;
    for (int j = 0; j < arr.Length; j++)
    {   
        k = new Random().Next(0, 90);
        temp = arr[j];
        arr[j] = arr[k];
        arr[k] = temp;
    }   
    return (arr);
}

int[,,] FillArrayX3IntRand(int rowMin, int rowMax, int digitMin, int digitMax)
{
    int m = new Random().Next(rowMin, rowMax);
    int n = new Random().Next(rowMin, rowMax);
    int z = new Random().Next(rowMin, rowMax);
    int [] rand = RandList();
    int countRand = 0;
    int[,,] arr = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {   
                arr[i, j, k] = rand[countRand];
                countRand++;
            }
        }
    }
    return arr;
}

void PrintArrayX3(int[,,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int depth = arr.GetLength(2);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write(arr[i, j, k] + "("); 
                PrintColorBlue($"{i}");
                Console.Write(",");
                PrintColorGreen($"{j}");
                Console.Write(",");
                PrintColorRed($"{k}");
                Console.Write(") ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] array = FillArrayX3IntRand(2,2,10,97);
PrintColorRed("\n Three demension matrix\nwith uniq 2-sign digits:\n\n");
PrintArrayX3(array);
