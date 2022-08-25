int[] CopyArray(int[] arra)
{
    int[] arrb = new int[arra.Length];
    for (int i = 0; i < arra.Length; i++)
    {
        arrb[i] = arra[i];
    }
    return arrb;
}

int arrLen = new Random().Next(5,10);
int[] arr = new int[arrLen];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,1000);
}
Console.WriteLine($"Random array: [{string.Join(", ", arr)}]");

Console.WriteLine($"Copied array: [{string.Join(", ", CopyArray(arr))}]");

