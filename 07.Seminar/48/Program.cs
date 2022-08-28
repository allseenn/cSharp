// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
        matrix[i,j] = i+j;
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}