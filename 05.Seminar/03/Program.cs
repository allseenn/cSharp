int[] array = { 1, 2, 3, 7, 18, 21, 1, 3 };
int number = 3;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] == number)
    {
        Console.WriteLine("Yes");
        break;
    }
    else if(array[i] != number)
    {
       Console.WriteLine("No");
    
    }
}
