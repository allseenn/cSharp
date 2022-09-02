int[] PascalRowArrayX1(int N, int rowLen)
{
    int[] arr = new int[rowLen];
    // nC0 = 1
    int prev = 1;
    int center = rowLen/2-N;
    int space = center+2;
    arr[center] = prev;
    for(int i = 1; i <= N; i++)
    { 
        // nCr = (nCr-1 * (n - r + 1))/r
        int curr = (prev * (N - i + 1)) / i;
        arr[space] = curr;
        prev = curr;
        space = space+2;
    }
    return arr;
}
  
int N = Convert.ToInt32(Console.ReadLine());
int[] array = PascalRowArrayX1(N,9);
Console.WriteLine(String.Join(" ", array));