int arrLen = new Random().Next(5,10);
double[] arr = new double[arrLen];
double min = Double.MaxValue;
double max = Double.MinValue;
Console.WriteLine($"Enter a real number for all {arrLen} elements in array:");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Element {i} = ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
    if(arr[i] > max) max = arr[i];
    if(arr[i] < min) min = arr[i];
}
Console.Write($"[{string.Join("; ", arr)}]");
Console.Write($" -> {max - min}");