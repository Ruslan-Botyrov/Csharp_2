// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

if (number == 1) Console.WriteLine("нет, будний день");
if (number == 2) Console.WriteLine("нет, будний день");
if (number == 3) Console.WriteLine("нет, будний день");
if (number == 4) Console.WriteLine("нет, будний день");
if (number == 5) Console.WriteLine("нет, будний день");
if (number == 6) Console.WriteLine("да, выходной день");
if (number == 7) Console.WriteLine("да, выходной день");
if (number > 7) Console.WriteLine("в неделе только 7 дней");
if (number < 1) Console.WriteLine("в неделе только 7 дней");