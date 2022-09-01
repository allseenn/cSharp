// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int m = new Random().Next(3,10);
int n = new Random().Next(3,10);
int[,] arr = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(-9,9);
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}

 Console.WriteLine();
int last = m-1;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(i == 0) 
        {
        Console.Write(arr[last,j] + "\t");
        }
        else if (i == last)
        {
        Console.Write(arr[0,j] + "\t");
        }
        //else Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}