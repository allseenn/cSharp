const int ARRAY_SIZE = 5;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
int[] array = FillArray(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($"[ {string.Join(", ", array)} ]");
ReverseArray(array);
Console.WriteLine($"[ {string.Join(", ", array)} ]");