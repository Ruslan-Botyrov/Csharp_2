// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine(value);

int x = value / 100;
int y = value % 10;
Console.WriteLine($"{x}{y}");