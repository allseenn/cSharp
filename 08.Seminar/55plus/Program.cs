// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int m = new Random().Next(3,10);
int n = new Random().Next(3,10);

int[,] arr = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(0,9);
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}

 Console.WriteLine();

for (int j = 0; j < n; j++)
{
    
    for (int i = 0; i < m; i++)
    {
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
  
}

