// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Give 2 demension array M X N");
Console.Write("Enter M zise: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N zise: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[m,n];
double sum = 0;
int temp = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i,j] = new Random().Next(1,101);
        Console.Write(matrix[i,j] + " ");
        
        sum += matrix[i,j];

        
    }
    Console.Write(sum/(temp+1));
    
    Console.WriteLine();
    
     

}
Console.WriteLine($"Сумма значений главной диоганали = {sum}");