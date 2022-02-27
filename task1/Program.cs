// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трехзначное число");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);
if (number < 100) Console.Write()

int x = number % 10;
Console.Write (x);
