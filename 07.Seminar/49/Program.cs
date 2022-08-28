// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Give 2 demension array M X N");
Console.WriteLine("Enter M zise");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N zise");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if(i%2 == 0 && j%2 == 0) 
        {
        matrix[i,j] = new Random().Next(-10,10);
        Console.Write($"({matrix[i,j]})");
        matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
        else matrix[i,j] = new Random().Next(-100,101);
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}