Console.WriteLine("Введите число");
string num = Console.ReadLine();
if (num.Length == 3 || num.Length > 3)
{Console.WriteLine("Третья цифра числа: " + num[2]);}
if (num.Length < 3)
{Console.WriteLine("Третьей цифры нет");}

