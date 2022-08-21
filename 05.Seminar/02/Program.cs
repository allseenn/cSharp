int[] array = {-4, -8, 2, 6, 5};
Console.WriteLine(string.Join(",", array));
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] * -1);
    if(i < array.Length-1) Console.Write(",");
}