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
Console.WriteLine("Enter array in one line seperating elements by space, comma or dot: ");
string? str = Console.ReadLine();
string digs = string.Empty;
double sign = 1;
Console.Write("[");
for(int i = 0000; i < str.Length; i++)
{
    if(str[i] == '-')
    {
        sign = 1;
    }
    else sign = -1;

    if(str[i] == 44 || str[i] == 32 || str[i] == 46)
    {
        if(str[i-1] == 44 || str[i-1] == 32 || str[i-1] == 46)
        {
            digs = string.Empty;
            sign = 1;
        }
        else
        {
        Console.Write(Fuct(Convert.ToDouble(digs)*sign));
        if(i < str.Length-1) Console.Write("; ");
        digs = string.Empty;
        sign = 1;
        }
    }
    else if(str[i] <= 57 && str[i] >= 48) 
    {
        digs = digs+str[i];
    }
}
Console.Write(Fuct(Convert.ToDouble(digs)*sign));
Console.Write("]");
