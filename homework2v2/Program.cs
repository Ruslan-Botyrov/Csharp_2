// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine(value);

char[] arr = value.ToString().ToCharArray(); // это преобразование числа в массив я нагуглил, просьба, разобрать данное преобразование на семинаре, а то не совсем его понимаю

Console.WriteLine($"{arr[0]}{arr[2]}");
