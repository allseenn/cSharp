// int ZnFrstMn, ZnConvertCh, ZnTexBox;
// do
// { ZnTexBox = i / 4;
// ZnFrstMn = ZnTexBox * 4;
// ZnConvertCh = i - ZnFrstMn;
// i = ZnTexBox;
// Console.Write(ZnConvertCh);
// } while (i > 0);
// int[] Converter(int n, int l)
// {
// int[] arr = new int[l];
// int box, first, convert;
// for (int i = arr.Length-1; i >= 0; i--)
// {
//     box = n / arr.Length;
//     first = box * arr.Length;
//     convert = n - first;
//     n = box;
//     arr[i] = convert;
// }
// return arr;
// }

Console.Write("Enter a decimail number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number/4);
// Console.WriteLine(String.Join(",", Converter(number, 4)));
