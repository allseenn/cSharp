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
        matrix[i,j] = new Random().Next(-100,101);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}