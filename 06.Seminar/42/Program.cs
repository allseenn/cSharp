// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
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
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ost = 0;
int num = number;
int count = 0;
for (int i = 0; i <= number; i++)
{
    ost = num%2;
    num = num/2;
    count++;
    if(num<=0) break;
    
    
}
int[] arr = new int[count];
for (int j = 0; j < arr.Length; j++)
{
    ost = number%2;
    number = number/2;
    arr[j] = ost;
}
Console.WriteLine(string.Join("",arr));
ReverseArray(arr);
Console.WriteLine(string.Join("",arr));