double Fuct (double number)
{
    double sum = number;
    if(number >= 0)
    {
        for(double i = 1; i < number; i++)
        {
        sum = i * sum;
        }
    return sum;
    }
    else 
    {
        for(double i = -1; i > number; i--)
        {
            sum = i * sum;
        }
    return sum; 
    }
}

//Введите массив одной строкой, разделяя элементы пробелом, запятой или точкой:
Console.WriteLine("Enter array in one line seperating by space, comma or dot: ");
string? str = Console.ReadLine();
string digs = string.Empty;
Console.Write("[");
for(int i = 0000; i < str.Length; i++)
{
    if(str[i] == 44 || str[i] == 32 || str[i] == 46 )
    {
        Console.Write(Fuct(Convert.ToDouble(digs)));
        if(i < str.Length-1) Console.Write("; ");
        digs = string.Empty;
    }
    if(str[i] <= 57 && str[i] >= 48) 
    {
        digs = digs+str[i];
    }
}
Console.Write(Fuct(Convert.ToDouble(digs)));
Console.Write("]");
