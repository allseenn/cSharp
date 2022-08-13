void Method1()
{
    Console.WriteLine("Method1");
}
Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Method2");

void Method21(string msg, int count)
{
    for(int i = 0; i < count; i++)
    Console.WriteLine(msg);
}
Method21(count: 1, msg:"Method21");

int Method3()
{
    return DateTime.Now.Year;
}
Console.WriteLine(Method3());