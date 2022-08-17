Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
for (int count = 0; count < i;) {
    Console.WriteLine ($"Введите {count + 1} элемент массива");
    array[count] = Convert.ToInt32(Console.ReadLine());
    count++;
}

int A = Cycle(array, 1);
Console.WriteLine(A);

int Cycle(int[] array, int i) 
{
    int sum = 1;
    for (int count = 1; count <array[i]; count++) 
    {
        sum = sum * count;
    }
    return sum;
}
