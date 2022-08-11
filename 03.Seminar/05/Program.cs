string[] A = new string [2]
Console.WriteLine("Введите число x1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число у1: ");
double У1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число у2: ");
double У2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt((X2-X1)*(X2-X1)+(У2-У1)*(У2-У1));
Console.WriteLine(length);
