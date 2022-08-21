int arrLen = new Random().Next(5,10);
int[] arr = new int[arrLen];
int even = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100,1000);
    if(arr[i]%2 == 0) even++;
}
Console.Write($"[{string.Join(",", arr)}]");
if(even > 0) Console.Write($" -> {even}");