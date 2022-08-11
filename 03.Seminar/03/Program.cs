Console.WriteLine("Enter quater: ");
int quater = Convert.ToInt32(Console.ReadLine());
string[] arr = {"x>0 y>0", "x<0 y>0", "x<0 y<0", "x>0 y<0"};
if(quater >=1 && quater <=4)
{
    Console.WriteLine(arr[quater-1]);
}
else
{
    Console.WriteLine("No such quater");
}