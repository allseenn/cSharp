// **Задача 51: **Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


Console.WriteLine("Give 2 demension array M X N");
Console.Write("Enter M zise: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N zise: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m,n];
int sum = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,101);
        Console.Write(matrix[i,j] + " ");
        if(i == j) sum += matrix[i,j];
    }
    Console.WriteLine();
    

}
Console.WriteLine($"Сумма значений главной диоганали = {sum}");