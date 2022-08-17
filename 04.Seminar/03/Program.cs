Console.Write("Введите любое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string number1 = Convert.ToString(number);
Console.WriteLine($"Количество цифр в числе равно {number1.Length}");
