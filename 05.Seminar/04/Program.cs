//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// ("Hello, World!");
Console.Write("Введите длину массива");
int l = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[l];
int l2 = 0;
if(arr.Length % 2 == 0)
{
    l2 = l/2;
}
else l2 - l/2+1;
int[] arr2 = new int[l2] 
for(int i=0; i< arr.Length; i++)
{
    Console.Write($"Введите элемент {arr[i]}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine);
}
// if(arr.Length % 2 == 0)
// {
//     int[] arr2 = new int[l/2];
// }
// else
// {
//     int[] arr2 = new int[l/2+1];
// }
int j = arr.Length;
for(int i=0; i<arr.Length; i++)
{
    arr2[i] = arr[i]*arr[j];
    j--;
}
Console.WriteLine(string.Join(",", arr));
Console.WriteLine(string.Join(",", arr2));