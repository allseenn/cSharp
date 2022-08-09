Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((number % 7 == 0 && number % 23 == 0)?"Да":"Нет");
