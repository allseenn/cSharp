int[] array = new int[8];
for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}
Console.Write($"[{String.Join(", ",array)}]");
