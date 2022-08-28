﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int m = new Random().Next(3,10);
int n = new Random().Next(3,10);
double[,] arr = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(-9,9) + new Random().NextDouble();
        Console.Write(Math.Round((arr[i,j]), 1) + "\t");
    }
    Console.WriteLine();
}
