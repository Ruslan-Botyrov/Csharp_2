// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);
int x = (number / 10) % 10;
Console.WriteLine($"вторая цифра введенного числа - {x}");
