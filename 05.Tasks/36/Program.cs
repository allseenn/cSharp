int arrLen = new Random().Next(5,10);
int[] arr = new int[arrLen];
int odd = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,1000);
    if(i%2 != 0) odd+=arr[i];
}
Console.Write($"[{string.Join(",", arr)}]");
Console.Write($" -> {odd}");