int Fuct (int number)
{
    int sum = number;
    if(number >= 0)
    {
        for(int i = 1; i < number; i++)
        {
        sum = i * sum;
        }
    return sum;
    }
    else 
    {
        for(int i = -1; i > number; i--)
        {
            sum = i * sum;
        }
    return sum; 
    }
}

//Введите массив одной строкой, разделяя элементы пробелом, запятой или точкой:
Console.WriteLine("Enter array in one line seperating by space, comma or dot: ");
string? str = Console.ReadLine();
Console.Write("[");
for(int i = 0; i < str.Length; i++)
{
    while(str[i] == 44 || str[i] == 32 || str[i] == 46) i++;
    if(str[i] <= 57 && str[i] >= 48) Console.Write(Fuct(str[i]-48));
    if(i < str.Length-1) Console.Write(", ");
}
Console.Write("]");