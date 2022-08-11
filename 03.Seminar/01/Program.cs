int[] point = new int[2];
Console.WriteLine("Enter X coordinate ");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinate ");
point[1] = Convert.ToInt32(Console.ReadLine());
if(point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("First quater");
}
else if(point[0] < 0 && point[1] > 0) 
{
     Console.WriteLine("Second quater");
}
else if(point[0] < 0 && point[1] < 0)
{
     Console.WriteLine("Second quater");
}
else if(point[0] > 0 && point[1] > 0) 
{
     Console.WriteLine("Second quater");
}
else 
{
    Console.WriteLine("Point on axis");
}