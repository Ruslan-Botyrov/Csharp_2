// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

char[] arr = number.ToString().ToCharArray();

if (number > 99) Console.WriteLine($"Третья цифра задонного числа - {arr[2]}");
if (number < -99) Console.WriteLine($"Третья цифра задонного числа - {arr[3]}");
else Console.WriteLine("Третьей цифры нет");