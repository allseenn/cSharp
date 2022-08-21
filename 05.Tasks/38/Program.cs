int arrLen = new Random().Next(5,10);
int[] arr = new int[arrLen];
int min = 1000;
int max = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,1000);
    if(arr[i] > max) max = arr[i];
    if(arr[i] < min) min = arr[i];
}
Console.Write($"[{string.Join(",", arr)}]");
Console.Write($" -> {max - min}");