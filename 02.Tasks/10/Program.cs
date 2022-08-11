Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((number>99 && number<1000 )?number/10%10:"Число не 3-х значное!");
