Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0 && number < 8)
{
    Console.WriteLine((number > 5 && number < 8)?"да":"нет");
}
else
{
    Console.WriteLine($"цивра {number} не является днем недели");
}