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

int[,,] FillArrayX3IntRand(int rowMin, int rowMax, int digitMin, int digitMax)
{
    int m = new Random().Next(rowMin, rowMax);
    int n = new Random().Next(rowMin, rowMax);
    int z = new Random().Next(rowMin, rowMax);
    Random a = new Random(); 
    List<int> randomList = new List<int>();
    int MyNumber = 0;

    int[,,] arr = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {   MyNumber = a.Next(digitMin, digitMax);
                //arr[i, j, k] = new Random().Next(digitMin, digitMax);
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                    arr[i, j, k] = MyNumber;
                }
                else arr[i, j, k] = MyNumber+i+k+j;
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
