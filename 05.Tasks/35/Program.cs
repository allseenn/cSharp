int[] arr = new int[123];
int cut = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,1000);
    if(arr[i] > 9 && arr[i] < 100) cut++;
}
Console.Write($"[{string.Join(",", arr)}]");
Console.Write($" -> {cut}");