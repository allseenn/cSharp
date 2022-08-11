Console.Write("Введите 3-х значное число: ");
string? number = Console.ReadLine();
Console.WriteLine((number.Length < 3)?"третьей цифры нет":number[2]);