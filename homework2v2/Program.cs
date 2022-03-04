// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine(value);

char[] arr = value.ToString().ToCharArray();
arr (x)= arr[0,2];
Console.WriteLine(x);
